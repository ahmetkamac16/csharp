using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFProject
{
    public partial class FRMStatistics : Form
    {
        public FRMStatistics()
        {
            InitializeComponent();
        }
        EFExampleDBEntities db = new EFExampleDBEntities();
        private void FRMStatistics_Load(object sender, EventArgs e)
        {         
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.LocationCapacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => x.LocationCapacity).ToString();
            lblAvgTourPrice.Text = db.Location.Average(x => x.LocationPrice).ToString();

            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.LocationCountry).FirstOrDefault();

            lblIstanbulTourCapacity.Text = db.Location.Where(x => x.LocationCity == "Istanbul").Select(y => y.LocationCapacity).FirstOrDefault().ToString();

            lblAvgCapacityTourInTurkey.Text = db.Location.Where(x => x.LocationCountry == "Turkey").Average(y => y.LocationCapacity).ToString();

            lblRomaGuide.Text = db.Location.Where(x => x.LocationCity == "Roma").Select(y => y.Guide.GuideName+" "+y.Guide.GuideSurname).FirstOrDefault();

            var maxCapacityId = db.Location.Max(x => x.LocationCapacity);
            lblMaxCapacityTour.Text = db.Location.Where(x =>  x.LocationCapacity == maxCapacityId).Select(y => y.LocationCapacity).FirstOrDefault().ToString();

            var expensiveTourId = db.Location.Max(y => y.LocationPrice);
            lblMostExpensiveTour.Text = db.Location.Where(x => x.LocationPrice == expensiveTourId).Select(y => y.LocationPrice).FirstOrDefault().ToString();

            lblTourCountAhmet.Text = db.Location.Count(x => x.GuideId == 1).ToString();  
        }
    }
}
