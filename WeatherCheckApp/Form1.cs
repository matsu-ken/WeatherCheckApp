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

      Dictionary<string, string> dictionaryStudent = new Dictionary<string, string>();
      dictionaryStudent.Add("016010", "北海道(札幌)");
      dictionaryStudent.Add("020010", "青森県");
      dictionaryStudent.Add("030010", "岩手県(盛岡)");
      dictionaryStudent.Add("040010", "宮城県(仙台)");
      dictionaryStudent.Add("050010", "秋田県");
      dictionaryStudent.Add("060010", "山形県");
      dictionaryStudent.Add("070010", "福島県");
      dictionaryStudent.Add("080010", "茨城県(水戸)");
      dictionaryStudent.Add("090010", "栃木県(宇都宮)");
      dictionaryStudent.Add("100010", "群馬県(前橋)");
      dictionaryStudent.Add("110010", "埼玉県(さいたま)");
      dictionaryStudent.Add("120010", "千葉県");
      dictionaryStudent.Add("130010", "東京都");
      dictionaryStudent.Add("140010", "神奈川県(横浜)");
      dictionaryStudent.Add("150010", "新潟県");
      dictionaryStudent.Add("160010", "富山県");
      dictionaryStudent.Add("170010", "石川県(金沢)");
      dictionaryStudent.Add("180010", "福井県");
      dictionaryStudent.Add("190010", "山梨県(甲府)");
      dictionaryStudent.Add("200010", "長野県");
      dictionaryStudent.Add("210010", "岐阜県");
      dictionaryStudent.Add("220010", "静岡県");
      dictionaryStudent.Add("230010", "愛知県(名古屋)");
      dictionaryStudent.Add("240010", "三重県津(");
      dictionaryStudent.Add("250010", "滋賀県(大津)");
      dictionaryStudent.Add("260010", "京都府");
      dictionaryStudent.Add("270000", "大阪府");
      dictionaryStudent.Add("280010", "兵庫県(神戸)");
      dictionaryStudent.Add("290010", "奈良県");
      dictionaryStudent.Add("300010", "和歌山県");
      dictionaryStudent.Add("310010", "鳥取県");
      dictionaryStudent.Add("320010", "島根県(松江)");
      dictionaryStudent.Add("330010", "岡山県");
      dictionaryStudent.Add("340010", "広島県");
      dictionaryStudent.Add("350020", "山口県");
      dictionaryStudent.Add("360010", "徳島県");
      dictionaryStudent.Add("370000", "香川県(高松)");
      dictionaryStudent.Add("380010", "愛媛県(松山)");
      dictionaryStudent.Add("390010", "高知県");
      dictionaryStudent.Add("400010", "福岡県");
      dictionaryStudent.Add("410010", "佐賀県");
      dictionaryStudent.Add("420010", "長崎県");
      dictionaryStudent.Add("430010", "熊本県");
      dictionaryStudent.Add("440010", "大分県");
      dictionaryStudent.Add("450010", "宮崎県");
      dictionaryStudent.Add("460010", "鹿児島県");
      dictionaryStudent.Add("471010", "沖縄県(那覇)");

      listBox1.DataSource = new BindingSource(dictionaryStudent, null);
      listBox1.DisplayMember = "Value";
      listBox1.ValueMember = "Key";
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
      ListBox listbox = (ListBox)sender;

    }
  }
}
 