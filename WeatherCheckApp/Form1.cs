using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codeplex.Data;
using System.Net;


namespace WeatherCheckApp {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      Text = "WeatherCheckApp";

      int id = 400010;

      var url = "http://weather.livedoor.com/forecast/webservice/json/v1?city=" + id;
      var req = WebRequest.Create(url);

      using (var res = req.GetResponse())
      using (var s = res.GetResponseStream()) {
        dynamic json = DynamicJson.Parse(s);
      }

    }
  }
}
