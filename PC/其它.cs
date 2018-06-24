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

//其实大部分的程序功能自学后都可以通过控件来实现，所以我能给出的代码其实很少。
//不过你要是能找到github这里相信你也有能力搞定基本的C#功能，我放在这里的代码可能只是省了你一些自己找资源的时间而已。

//务必和你要进行串口通信的队友确定好串口通信协议（就是你发的东西和它发的东西代表了什么，是怎样工作的）
//最好定一个格式，写在一个文本文档里面
//我和我队友就吃过亏，我们有一段时间为了省事就没有把新的协议更新到文本文档里面，直接口头定协议
//结果到后来协议太杂太乱了，这个和那个是怎么工作的自己都有点搞不清楚
//所以规范真的很重要

//千万要重视外观设计，颜值越高越好
//你觉得那些检查的专家和投资商逛到你这里的时候会去看你们的底层代码吗？
//颜值真的太重要太重要了
//我们组利用surface pro的触屏功能设计了一套触屏为主的程序，而不是像别的组一样在窗体里加一大堆控件
//当然如果你们没有surface pro但想要实现触屏功能也可以采取折中的方法
//找个ipad或者安卓平板来个远程桌面和你的windows远程就可以了
//我们组设计的程序中，客户与GUI程序交互的控件只有一种————button
//我们把button设置成全透明的，然后在button的位置搞一张png图片，这样看起来就像是点击图片就可以触发button事件一样（png图片的透明特性了解一下）
//另外为了提高程序颜值我没有采用按下按钮弹出管理员窗体，而是采取按下ESC弹出管理员窗体的方法，因为进管理员界面的按钮很影响美观啊
//Form控件可以设置一个属性值，最下面“杂项”有个CancelButton，这个属性值可以设置在当前窗体按下ESC后的动作
//比如你把这个值设置为button1，那么你按下ESC后的效果就和点击button1的效果一样了
//然后你把button1设置成全透明或者隐藏就可以了

//另外有个比较经典的结构我经常用
//声明一个public static的静态变量，然后通过这个静态变量和某一窗体的timer控件结合使用，可以干很多很多事情
