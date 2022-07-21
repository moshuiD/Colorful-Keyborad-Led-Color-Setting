# Colorful Keyborad Led Color Setting
Colorful Keyborad Led Color Setting  
My laptop is COLORFUL 将星x15 at 2022.  
<s>也许神舟笔记本也可以使用这个调节键盘灯</s>  
[English introduce](#english)  
[中文介绍](#中文)  
# English  
This is a software to change Colorful laptop's keyboard Led colorful.  
+ ## Why I build it?  
+ I'm a freshman in collage in 2022/9/1.To study in collage I bought this ["COLORFUL"](https://www.colorful.cn/) laptop.All things are right,but this laptop have not RGB loop function.That was why my built it.  
+ ## How to build it?  
+ First of all,I used dnspy to check LedKeyboardSetting.exe source code and debug it.  
+ <s> By the way,what a unuseless code in LedKeyboardSetting. </s>  
+ Secondly through my reverse I finded InsydeDCHU.dll that is the key to setting LED color.  
+ And then I use ida to find this  
+ `__int64 __fastcall SetDCHU_Data(int a1, __int64 a2, int a3)`  
+ I confirm this can set color to LED.At the last I use C# to make my Colorful Keyborad Led Color Setting.  
+ <s> Everythings are easy. </s>  
+  ## How to use it?  
+  1.Confirm "InsydeDCHU.dll" and my software in same path  
+  2.Accept disclaimers  
+  3.Software UI are Chinese google translate can help you :D  
+  ![](https://github.com/moshuiD/Colorful-Keyborad-Led-Color-Setting/blob/main/ui.png)  
+  ## Disclaimers  
+  1.Powered by moshui.
+  2.If have any hardware damage.I have not any duty to pay for it.  

# 中文  
此程序可以修改七彩虹笔记本键盘灯颜色  
+ ##为什么制作它？
+ 我在2022年9月1日会成为大一新生。为了学习买了这个[七彩虹](https://www.colorful.cn/)笔记本.这个笔记本一切都很让我满意，就是这个键盘灯他没有RGB循环和自定义颜色功能。为了弥补这个，我写了此程序  
+ ## 怎么制作的？  
+ 首先使用dnspy查看源代码和调试  
+ <s> 顺便说一下，他这个无用的代码真的多 </s>  
+ 然后通过我的逆向我发现了InsydeDCHU.dll这个dll  
+ 接着使用ida发现这个函数  
+ ` __int64 __fastcall SetDCHU_Data(int a1, __int64 a2, int a3)`  
+ 我确定这个能设置键盘灯颜色，然后使用C#编写程序  
+ ## 怎么使用？
+ 1.确保InsydeDCHU.dll与本程序位于同一个文件夹
+ 2.接受免责声明
+ ## 程序截图  
+ ![](https://github.com/moshuiD/Colorful-Keyborad-Led-Color-Setting/blob/main/ui.png)
