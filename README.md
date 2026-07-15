# Colorful Keyborad Led Color Setting
Colorful Keyborad Led Color Setting  
My laptop is [COLORFUL 将星x15 at 2022](https://www.colorful.cn/product_show.aspx?mid=158&id=13).  
<s>也许神舟笔记本也可以使用这个调节键盘灯</s>  
[English introduction](#english)  
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
+ ## 为什么制作它？
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

---

# Fork 修改版 (by eryuemu)

本项目为个人 Fork 修改版，主要进行了界面美化以及底层运行优化。

## 🌟 主要改动与优化特性

1. **现代深色风格界面**：
   - 界面整体采用深暗底色，边缘配以青色发光光条，风格简洁硬朗。
   - 速度与亮度调节使用 15 段电子格能量条形式，替代原版 Windows 默认滑块。

2. **自适应全屏与窗口拉伸**：
   - 支持窗口任意拉伸和最大化，面板和滑块会自适应屏幕宽度。

3. **绿色免安装运行**：
   - 清除或排除了所有系统启动残留注册表，软件不写系统，配置全部在本地 `config.txt` 中自包含。
   - 只需把 `.exe` 和 `InsydeDCHU.dll` 放在同一个文件夹下双击即可运行。

4. **底层写入异步化**：
   - 将驱动写入操作移至后台异步线程执行，杜绝了因底层物理写入延迟导致的前端界面假死卡顿。

5. **新增效果模式与实用选项**：
   - **灯光效果扩展**：支持“呼吸灯效”与“闪烁警示”模式切换。
   - **新增三大高级灯效**：
     - **音乐律动**：通过 WASAPI 捕获系统音频输出的峰值电平，背光亮度和颜色随音乐节拍同步跳动。
     - **温度映射**：通过 WMI 查询 CPU 实时温度（如无管理员权限则自动降级为 CPU 负载率），在冰蓝、青绿、暖黄、橙红之间做平滑渐变展示。
     - **屏幕氛围**：实时捕获主屏幕画面，通过底层的 GDI `StretchBlt` 进行拉伸拷贝取色（避免全屏截图的内存和 GC 消耗），同步渲染至键盘背光。
   - **全局七彩变色开关**：为呼吸灯效、闪烁警示、音乐律动添加“七彩变色”开关，开启后灯效运行中将自动变换彩虹颜色，且按钮文字颜色会实时同步当前键盘颜色。
   - **开机自启与托盘**：支持“Windows开机自启” and “启动时最小化到托盘”，支持后台静默运行。
   - **安全测试模式**：支持“安全测试模式”，开启后不进行物理写入，便于安全调试。
   - **状态实时显示**：底部增加硬件驱动连接状态栏，运行状态和检测到的 CPU 温度/负载一目了然。

## 🛠️ 运行环境

- **支持/已测试硬件**：七彩虹 隐星 P16 Pro (i9-13900HX / RTX显卡) 以及其他使用单区 RGB 键盘的七彩虹将星/隐星系列笔记本
- **软件架构**：x64 原生（必须在 64 位系统下运行）
- **依赖文件**：`InsydeDCHU.dll` (须放置在与 `ColorfulLedKeyboardSet.exe` 同一目录下)

## 🚀 快速使用

1. 确保文件夹中同时包含 `ColorfulLedKeyboardSet.exe` 和 `InsydeDCHU.dll`。
2. 双击 `ColorfulLedKeyboardSet.exe` 运行即可。
