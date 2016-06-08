﻿using System;
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

        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("016010", "北海道(札幌)");
        dictionary.Add("020010", "青森県");
        dictionary.Add("030010", "岩手県(盛岡)");
        dictionary.Add("040010", "宮城県(仙台)");
        dictionary.Add("050010", "秋田県");
        dictionary.Add("060010", "山形県");
        dictionary.Add("070010", "福島県");
        dictionary.Add("080010", "茨城県(水戸)");
        dictionary.Add("090010", "栃木県(宇都宮)");
        dictionary.Add("100010", "群馬県(前橋)");
        dictionary.Add("110010", "埼玉県(さいたま)");
        dictionary.Add("120010", "千葉県");
        dictionary.Add("130010", "東京都");
        dictionary.Add("140010", "神奈川県(横浜)");
        dictionary.Add("150010", "新潟県");
        dictionary.Add("160010", "富山県");
        dictionary.Add("170010", "石川県(金沢)");
        dictionary.Add("180010", "福井県");
        dictionary.Add("190010", "山梨県(甲府)");
        dictionary.Add("200010", "長野県");
        dictionary.Add("210010", "岐阜県");
        dictionary.Add("220010", "静岡県");
        dictionary.Add("230010", "愛知県(名古屋)");
        dictionary.Add("240010", "三重県(津)");
        dictionary.Add("250010", "滋賀県(大津)");
        dictionary.Add("260010", "京都府");
        dictionary.Add("270000", "大阪府");
        dictionary.Add("280010", "兵庫県(神戸)");
        dictionary.Add("290010", "奈良県");
        dictionary.Add("300010", "和歌山県");
        dictionary.Add("310010", "鳥取県");
        dictionary.Add("320010", "島根県(松江)");
        dictionary.Add("330010", "岡山県");
        dictionary.Add("340010", "広島県");
        dictionary.Add("350020", "山口県");
        dictionary.Add("360010", "徳島県");
        dictionary.Add("370000", "香川県(高松)");
        dictionary.Add("380010", "愛媛県(松山)");
        dictionary.Add("390010", "高知県");
        dictionary.Add("400010", "福岡県");
        dictionary.Add("410010", "佐賀県");
        dictionary.Add("420010", "長崎県");
        dictionary.Add("430010", "熊本県");
        dictionary.Add("440010", "大分県");
        dictionary.Add("450010", "宮崎県");
        dictionary.Add("460010", "鹿児島県");
        dictionary.Add("471010", "沖縄県(那覇)");

        listBox1.DataSource = new BindingSource(dictionary, null);
        listBox1.DisplayMember = "Value";
        listBox1.ValueMember = "Key";

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
      ListBox listbox = (ListBox)sender;
      listbox.DisplayMember = "Value";
      listbox.ValueMember = "Key";
      var url = "http://weather.livedoor.com/forecast/webservice/json/v1?city=" + listbox.SelectedValue;
      var req = WebRequest.Create(url);

      using (var res = req.GetResponse())
      using (var s = res.GetResponseStream()) {
        dynamic json = DynamicJson.Parse(s);

        dynamic today = json.forecasts[0];
        string dateLabel = today.dateLabel;
        string date = today.date;
        string telop = today.telop;
        var situation = json.description.text;

        dynamic tomorrow = json.forecasts[1];
        string dateLabel1 = tomorrow.dateLabel;
        string date1 = tomorrow.date;
        string telop1 = tomorrow.telop;

        dynamic dayaftertomorrow = json.forecasts[2];
        string dateLabel2 = dayaftertomorrow.dateLabel;
        string date2 = dayaftertomorrow.date;
        string telop2 = dayaftertomorrow.telop;

        label1.Text = listBox1.Text + "\n\n<" + dateLabel + ">" + "\n" + date
          + "\n天気 : " + telop + "\n\n\n" + situation;
        label2.Text = "\n\n<" + dateLabel1 + ">" + "\n" + date1 + "\n天気 : " + telop1;
        label3.Text = "\n\n<" + dateLabel2 + ">" + "\n" + date2 + "\n天気 : " + telop2;
      }
    }
  }
}
