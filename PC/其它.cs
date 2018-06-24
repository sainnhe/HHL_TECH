//延时函数
using System.Diagnostics;               //Stopwatch类的调用
using System.Threading;                 //Threading的调用

    private void button1_Click(object sender, EventArgs e)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        Thread.Sleep(1000);                 //1000ms
        sw.Stop();
    }

//多线程
using System.Threading; 

    private void button1_Click(object sender, EventArgs e)
    {
        Thread t = new Thread(TODO);
        t.Start();
    }

    void TODO()
    {
        //statement
    }

//为了提高程序颜值我没有采用按下按钮弹出管理员窗体，而是采取按下ESC弹出管理员窗体的方法，因为进管理员界面的按钮很影响美观啊
//Form控件可以设置一个属性值，最下面“杂项”有个CancelButton，这个属性值可以设置在当前窗体按下ESC后的动作
//比如你把这个值设置为button1，那么你按下ESC后的效果就和点击button1的效果一样了
//然后你把button1设置成全透明或者隐藏就可以了

//另外有个比较经典的结构我经常用
//声明一个public static的静态变量，然后通过这个静态变量和某一窗体的timer控件结合使用，可以干很多很多事情