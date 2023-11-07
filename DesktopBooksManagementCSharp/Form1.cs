using DesktopBooksManagementCSharp.Model;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace DesktopBooksManagementCSharp
{
    public partial class MainForm : Form
    {
        private XPCollection _collection;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(Properties.DataResurces.ConnectionString, AutoCreateOption.DatabaseAndSchema);
            LoadData();
        }

        private void LoadData()
        {
            var collection = new XPCollection(typeof(Book));
            _collection = collection;
            grdBooks.DataSource = collection;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtTitle.Text = String.Empty;
            txtAuthor.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtPages.Text = String.Empty;
            dtPublished.Text = String.Empty;
            txtTitle.Focus();
            txtId.Text = String.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                var book = new Book(uow);
                book.Title = txtTitle.Text;
                book.Author = txtAuthor.Text;
                book.Description = txtDescription.Text;
                book.Published = dtPublished.DateTime;
                int pages;
                if(int.TryParse(txtPages.Text, out pages))
                    book.Pages = pages;

                var idExist = uow.Query<Book>().Where(x => x.Oid.ToString() == txtId.Text).Any();
                if(idExist)
                {
                    var dlgResult = XtraMessageBox.Show($"The book with the specified Id already exists. Do you want to update it?", "Mesasge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True);
                    if (dlgResult == DialogResult.Yes)
                        btnUpdate_Click(sender, e);
                    else
                        txtId.Text = String.Empty;
                }
                else
                {
                    uow.CommitChanges();
                    _collection.Reload();
                    XtraMessageBox.Show("Save completed!", "Message");
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                var id = int.Parse(txtId.Text);
                var book = uow.Query<Book>().Where(s => s.Oid == id).FirstOrDefault();
                if (book == null)
                {
                    XtraMessageBox.Show("The book with the specified id could not be found!", "Message");
                }
                else
                {
                    book.Title = txtTitle.Text;
                    book.Author = txtAuthor.Text;
                    book.Description = txtDescription.Text;
                    book.Published = dtPublished.DateTime;
                    int pages;
                    if (int.TryParse(txtPages.Text, out pages))
                        book.Pages = pages;

                    uow.CommitChanges();
                    _collection.Reload();
                    XtraMessageBox.Show("Update completed!", "Message");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dlgResult = XtraMessageBox.Show($"Do you want delete book?", "Mesasge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True);
            if (dlgResult == DialogResult.Yes)
            {
                using (var uow = new UnitOfWork())
                {
                    var list = gridViewBooks.GetSelectedRows().Select(x => gridViewBooks.GetRow(x) as Book).ToList();

                    var students = uow.Query<Book>().AsEnumerable().Where(s => list.Any(x => s.Oid == x.Oid)).ToList();
                    uow.Delete(students);
                    uow.CommitChanges();
                    _collection.Reload();
                }
            }
        }

        private void gridViewBooks_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var book = gridViewBooks.GetFocusedRow() as Book;
            if (book != null)
            {
                txtTitle.Text = book.Title;
                txtAuthor.Text = book.Author;
                txtDescription.Text = book.Description;
                txtPages.Text = book.Pages.ToString();
                dtPublished.DateTime = book.Published;
                txtId.Text = book.Oid.ToString();
            }
        }
    }
}
