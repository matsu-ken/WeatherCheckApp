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
using System.Globalization;



namespace WeatherCheckApp {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      //タイトルバーにプログラム名を表示
      this.Text = "WeatherCheckApp";

      //Dictionaryクラスの宣言(Key=string型、Value=string型)
      Dictionary<string, string> prefecturalCapital = new Dictionary<string, string>();
      //Add()メソッドでの(Key, Value)の追加
        prefecturalCapital.Add("016010", "北海道(札幌)");
        prefecturalCapital.Add("020010", "青森県");
        prefecturalCapital.Add("030010", "岩手県(盛岡)");
        prefecturalCapital.Add("040010", "宮城県(仙台)");
        prefecturalCapital.Add("050010", "秋田県");
        prefecturalCapital.Add("060010", "山形県");
        prefecturalCapital.Add("070010", "福島県");
        prefecturalCapital.Add("080010", "茨城県(水戸)");
        prefecturalCapital.Add("090010", "栃木県(宇都宮)");
        prefecturalCapital.Add("100010", "群馬県(前橋)");
        prefecturalCapital.Add("110010", "埼玉県(さいたま)");
        prefecturalCapital.Add("120010", "千葉県");
        prefecturalCapital.Add("130010", "東京都");
        prefecturalCapital.Add("140010", "神奈川県(横浜)");
        prefecturalCapital.Add("150010", "新潟県");
        prefecturalCapital.Add("160010", "富山県");
        prefecturalCapital.Add("170010", "石川県(金沢)");
        prefecturalCapital.Add("180010", "福井県");
        prefecturalCapital.Add("190010", "山梨県(甲府)");
        prefecturalCapital.Add("200010", "長野県");
        prefecturalCapital.Add("210010", "岐阜県");
        prefecturalCapital.Add("220010", "静岡県");
        prefecturalCapital.Add("230010", "愛知県(名古屋)");
        prefecturalCapital.Add("240010", "三重県(津)");
        prefecturalCapital.Add("250010", "滋賀県(大津)");
        prefecturalCapital.Add("260010", "京都府");
        prefecturalCapital.Add("270000", "大阪府");
        prefecturalCapital.Add("280010", "兵庫県(神戸)");
        prefecturalCapital.Add("290010", "奈良県");
        prefecturalCapital.Add("300010", "和歌山県");
        prefecturalCapital.Add("310010", "鳥取県");
        prefecturalCapital.Add("320010", "島根県(松江)");
        prefecturalCapital.Add("330010", "岡山県");
        prefecturalCapital.Add("340010", "広島県");
        prefecturalCapital.Add("350020", "山口県");
        prefecturalCapital.Add("360010", "徳島県");
        prefecturalCapital.Add("370000", "香川県(高松)");
        prefecturalCapital.Add("380010", "愛媛県(松山)");
        prefecturalCapital.Add("390010", "高知県");
        prefecturalCapital.Add("400010", "福岡県");
        prefecturalCapital.Add("410010", "佐賀県");
        prefecturalCapital.Add("420010", "長崎県");
        prefecturalCapital.Add("430010", "熊本県");
        prefecturalCapital.Add("440010", "大分県");
        prefecturalCapital.Add("450010", "宮崎県");
        prefecturalCapital.Add("460010", "鹿児島県");
        prefecturalCapital.Add("471010", "沖縄県(那覇)");
      //listBox1にprefecturalCapitalを表示
      this.listBox1.DataSource = new BindingSource(prefecturalCapital, null);
      this.listBox1.DisplayMember = "Value";
      this.listBox1.ValueMember = "Key";
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
      ListBox listbox = (ListBox)sender;
      //DisplayMember：表示に使う値
      listbox.DisplayMember = "Value";
      //ValueMember：実際の値
      listbox.ValueMember = "Key";

      //Livedoor Weather Web Service の基本URL + 地域のID
      string url = "http://weather.livedoor.com/forecast/webservice/json/v1?city=" + listbox.SelectedValue;
      //リクエストを作成
      WebRequest request = WebRequest.Create(url);
      //レスポンスを取得
      using (WebResponse response = request.GetResponse())
      //ストリームを取得、{}内で()内が有効
      using (System.IO.Stream stream = response.GetResponseStream()) {
        //streamをdynamic型に変換
        dynamic json = DynamicJson.Parse(stream);
        
        //今日の情報
          dynamic today = json.forecasts[0];
          string dateLabel = today.dateLabel;
          string date = today.date;
        //明日の情報
          dynamic tomorrow = json.forecasts[1];
          string dateLabel1 = tomorrow.dateLabel;
          string date1 = tomorrow.date;
        //明後日の情報
          dynamic dayAfterTomorrow = json.forecasts[2];
          string dateLabel2 = dayAfterTomorrow.dateLabel;
          string date2 = dayAfterTomorrow.date;

        //天気概況
          string situation = json.description.text;
        //dateをDateTime型に変換
          DateTime dt = DateTime.Parse(date);
          DateTime dt1 = DateTime.Parse(date1);
          DateTime dt2 = DateTime.Parse(date2);
        //和暦でDateTime型を文字列に変換
          CultureInfo japaneseCalendar = new CultureInfo("ja-JP", false);
          japaneseCalendar.DateTimeFormat.Calendar = new JapaneseCalendar();

        //今日の気温(Max & Min)
          StringBuilder tempMax = new StringBuilder();
          dynamic todayTempMax = today.temperature.max;
          if (todayTempMax != null) {
            tempMax.AppendFormat("{0}℃", todayTempMax.celsius);
          }
          else {
            tempMax.Append("---");
          }
          StringBuilder tempMin = new StringBuilder();
          dynamic todayTempMin = today.temperature.min;
          if (todayTempMin != null) {
            tempMin.AppendFormat("{0}℃", todayTempMin.celsius);
          }
          else {
            tempMin.Append("---");
          }
        //明日の気温(Max & Min)
          StringBuilder tempMax1 = new StringBuilder();
          dynamic tomorrowTempMax = tomorrow.temperature.max;
          if (tomorrowTempMax != null) {
            tempMax1.AppendFormat("{0}℃", tomorrowTempMax.celsius);
          }
          else {
            tempMax1.Append("---");
          }
          StringBuilder tempMin1 = new StringBuilder();
          dynamic tomorrowTempMin = tomorrow.temperature.min;
          if (tomorrowTempMin != null) {
            tempMin1.AppendFormat("{0}℃", tomorrowTempMin.celsius);
          }
          else {
            tempMin1.Append("---");
          }
        //明後日の気温(Max & Min)
          StringBuilder tempMax2 = new StringBuilder();
          dynamic dayafterTempMax = dayAfterTomorrow.temperature.max;
          if (dayafterTempMax != null) {
            tempMax2.AppendFormat("{0}℃", dayafterTempMax.celsius);
          }
          else {
          tempMax2.Append("---");
          }
          StringBuilder tempMin2 = new StringBuilder();
          dynamic dayafterTempMin = dayAfterTomorrow.temperature.min;
          if (dayafterTempMin != null) {
          tempMin2.AppendFormat("{0}℃", dayafterTempMin.celsius);
          }
          else {
            tempMin2.Append("---");
          }

          this.label1.Text = listBox1.Text;
          this.Date.Text = "<" + dateLabel + ">\n\n" + dt.ToString("gy年MM月dd日(ddd)", japaneseCalendar);
          this.Date1.Text = "<" + dateLabel1 + ">\n\n" + dt1.ToString("gy年MM月dd日(ddd)", japaneseCalendar);
          this.Date2.Text = "<" + dateLabel2 + ">\n\n" + dt2.ToString("gy年MM月dd日(ddd)", japaneseCalendar);
      
          this.Temperature.Text = "最高気温 : " + tempMax.ToString() + "\n最低気温 : " + tempMin.ToString();
          this.Temperature1.Text = "最高気温 : " + tempMax1.ToString() + "\n最低気温 : " + tempMin1.ToString();
          this.Temperature2.Text = "最高気温 : " + tempMax2.ToString() + "\n最低気温 : " + tempMin2.ToString();
          
          this.Situation.Text = situation;

        //天気画像
          this.pictureBox1.ImageLocation = json.forecasts[0].image.url;
          this.pictureBox2.ImageLocation = json.forecasts[1].image.url;
          this.pictureBox3.ImageLocation = json.forecasts[2].image.url;

        
          
         

         
          
      }
    }
  }
}
