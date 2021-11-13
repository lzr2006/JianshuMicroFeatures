using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tools_UserAssetsViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //获取用户的简书钻
        string Geter = BasicApis.GetUserJsonDataApi(TextBox1.Text);
        JavaScriptSerializer aparser = new JavaScriptSerializer();
        Struct.FP nowUserFp = aparser.Deserialize<Struct.FP>(Geter);
        nowUserFp.jsd_balance = nowUserFp.jsd_balance / 1000;
        //现在获取用户的总资产
        //是的 我又要开始传统艺能了
        string htmlObject = BasicApis.GetUserPCHtmlDataApi(TextBox1.Text);
        int userAssets = Convert.ToInt32(
            htmlObject.Split(new string[] { "<div>总资产</div>" }
        , StringSplitOptions.None)[0].Split(new string[] 
        { "<div class=\"meta-block\">" },StringSplitOptions.None)[6].Split(new string[] 
            { "<p>" },StringSplitOptions.None)[1].Split(new string[]{ "</p>" },
            StringSplitOptions.None)[0]
            );
        int nowUserFTN = userAssets - nowUserFp.jsd_balance;

        this.Label_FP.Text = $"他的简书钻：{nowUserFp.jsd_balance}";
        this.Label_FTN.Text = $"他的简书贝：{nowUserFTN}";

        //创建数据显示
        var dt = CreatData(nowUserFp.jsd_balance,nowUserFTN);

        Chart_Info.DataSource = dt;//绑定数据
        Chart_Info.Series["Series1"].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Pie;//设置图表类型
        Chart_Info.Series[0].XValueMember = "AssetsItem";//X轴数据成员列
        Chart_Info.Series[0].YValueMembers = "Count";//Y轴数据成员列
        Chart_Info.Series[0].LegendText = "AssetsItem";
        Chart_Info.Series[0].IsValueShownAsLabel = true;//显示坐标值

        Chart1.DataSource = dt;//绑定数据
        Chart1.Series["Series1"].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.SplineArea;//设置图表类型
        Chart1.Series[0].XValueMember = "AssetsItem";//X轴数据成员列
        Chart1.Series[0].YValueMembers = "Count";//Y轴数据成员列
        Chart1.Series[0].LegendText = "AssetsItem";
        Chart1.Series[0].IsValueShownAsLabel = true;//显示坐标值
    }

    /// <summary>
    /// 创建一张二维数据表
    /// </summary>
    /// <returns>Datatable类型的数据表</returns>
    public DataTable CreatData(int FP,int FTN)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("AssetsItem", System.Type.GetType("System.String"));
        dt.Columns.Add("Count", System.Type.GetType("System.String"));

        string[] n = new string[] { "简书钻","简书贝"};
        string[] c = new string[] { FP.ToString(),FTN.ToString()};

        DataRow dr = dt.NewRow();
        dr["AssetsItem"] = n[0];
        dr["Count"] = c[0];
        dt.Rows.Add(dr);

        DataRow dra = dt.NewRow();
        dra["AssetsItem"] = n[1];
        dra["Count"] = c[1];

        dt.Rows.Add(dra);

        return dt;
    }
}