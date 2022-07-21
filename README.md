# Colorful Keyborad Led Color Setting
Colorful Keyborad Led Color Setting  
[English introduce](#english) [中文介绍]()
# English  
This is a software to change Colorful laptop's keyboard Led colorful.  
+ ## Why I build it?  
+ I'm a freshman in collage in 2022/9/1.To study in collage I bought this ["COLORFUL"](https://www.colorful.cn/) laptop.All things are right,but this laptop have not RGB loop function.That was why my built it.  
+ ## How to build it?  
+ First of all,I used dnspy to check LedKeyboardSetting.exe source code and debug it.<s> By the way,what a unuseless code in LedKeyboardSetting </s>.Secondly through my reverse I finded InsydeDCHU.dll that is the key to setting LED color.And then I use ida to find this `__int64 __fastcall SetDCHU_Data(int a1, __int64 a2, int a3)` I confirm this can set color to LED.At the last I use C# to make my Colorful Keyborad Led Color Setting.  
+ <s> Everythings are easy. </s>  
+  ## How to use it?  
+  1.Confirm "InsydeDCHU.dll" and my software in same path  
++ How to find "InsydeDCHU.dll"?  
++ Go to Check C:\Program Files\WindowsApps\CLEVOCO.LedKeyboardSetting_3.77.0.0_x64__6h6z29zh29qx0("_3.77.0.0_x64__6h6z29zh29qx0" may not same)\CC.  
++ Find it and copy to my color seting software same path ("if you can't copy or can't open WindowsApp folder just google it")
