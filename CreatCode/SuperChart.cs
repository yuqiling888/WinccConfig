using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//引入需要的命名空间
using System.Windows.Forms.DataVisualization.Charting;

namespace StudentGuanli
{
    /// <summary>
    /// 高级图表设置类
    /// </summary>
    public class SuperChart
    {
        //当前要使用的图表控件对象
        private Chart chart= null;
        public SuperChart(Chart chart) 
        {
            this.chart = chart;
        }

        /// <summary>
        /// 绘制图表的通用方法
        /// </summary>
        /// <param name="chartType">图表的类型</param>
        /// <param name="dataList">绘制图表需要的数据</param>
        public void ShowChart(SeriesChartType chartType,IList<ChartData> dataList )
        {
            //【1】清除所有的图表序列
            this.chart.Series.Clear();
            //【2】创建一个图表序列对象（一个图表可以添加多个图表序列，也就是绘图对象
            Series series1 = new Series();
            series1.ChartType = chartType;//显示图表对象显示的类型 
            this.chart.Series.Add(series1);//添加到图表序集合

            //【3】设置当前图表的各种属性值
            for (int i = 0; i < dataList.Count; i++)
            {
                //【3.1】获取数据对象的两个值
                string text = dataList[i].Text;
                double value = dataList[i].Value;
                //【3.2】使用x和y的值将dataPoint的值写进去
                series1.Points.AddXY(text, value);
                //【3.3】设置数据点的显示内容
                series1.Points[i].LabelToolTip = value.ToString();//鼠标放在标签上的显示
                series1.Points[i].ToolTip = value.ToString();//图形上面的提示
                //【3.4】根据图形样式设置显示的形式和内容
                if(chartType==SeriesChartType.Pie)
                {
                    //series1.Points[i].Label = "#AXISLABEL(#VAL)";//设置标签显示内容=X轴内容+value值
                    series1.Points[i].Label = "#AXISLABEL（#PERCENT)";//x轴+百分比
                    // series1.Points[i].Label = "#AXISLABEL(#VAL)(#PERCENT)";
                    series1["PieLabelStyle"] = "outside";  //在外部显示
                    //series1["PieLableStyle"] = "inside";  //在内部显示
                    series1["PieLineColor"] = "Black";//连线颜色
                }
                else if(chartType==SeriesChartType.Doughnut)//圆环图
                {
                    series1.Points[i].Label = "#AXISLABEL(#PERCENT)";
                    series1["PieLableStyle"] = "inside";
                }
                else//如果是其他图形
                {
                    series1.Points[i].Label = "(#PERCENT)";//显示百分比

                }
                if(chartType!=SeriesChartType.Pie)
                {
                    series1.Points[i].AxisLabel = string.Format("{0} {1}", text, value);
                }
            }
            //【4】设置图表绘图区的的X值和Y坐标值（Y:表示具体要显示数值之间的间隔）
            this.chart.ChartAreas[0].AxisY.Interval = 10;
            this.chart.ChartAreas[0].AxisX.Interval = 1;
          
        }
    }
}
