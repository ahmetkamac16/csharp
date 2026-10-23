using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EFProject
{
    public partial class FRMLocation : Form
    {
        public FRMLocation()
        {
            InitializeComponent();
        }
        EFExampleDBEntities db = new EFExampleDBEntities();

        private void btnList_Click_1(object sender, EventArgs e)
        {
            var values = db.Location.Select(x => new
            {
                x.LocationId,
                x.LocationCity,
                x.LocationCountry,
                x.LocationCapacity,
                x.LocationPrice,
                x.DayNight,
                Guide = x.Guide.GuideName + " "+ x.Guide.GuideSurname
            }).ToList();

            dataGridView1.DataSource = values;
        }

        private void FRMLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();

            cmbGuide.DisplayMember = "FullName"; 
            cmbGuide.ValueMember = "GuideId";     
            cmbGuide.DataSource = values;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Location location = new Location();
            location.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            location.LocationCity = txtCity.Text;
            location.LocationCountry = txtCountry.Text;
            location.LocationPrice = int.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Succesfully!");
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Succesfully!");
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.LocationCity = txtCity.Text;
            updatedValue.LocationCountry = txtCountry.Text;
            updatedValue.LocationPrice = decimal.Parse(txtPrice.Text);
            updatedValue.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Succesfully!");
        }

       
    }
}
