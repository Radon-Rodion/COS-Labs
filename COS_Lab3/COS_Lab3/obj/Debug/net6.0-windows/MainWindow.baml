   M S B A M L   `   `   `  ????C  ?COS_Lab3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:COS_Lab3COS_Lab3  5   	       COS_Lab3.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NOxyPlot.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:COS_Lab3     5   	     ? Title$  
MainWindow??5	   	   $	??750??6   $
??1000??6)   .??5
      ?  ? RowDefinitions 5   
   ?? 5      $
??100* ?6   ?? 5      $
??100* ?6   ?? 5      $
??110* ?6   ?? 5      $??50 ?6   .+?5   
   ? $??0??6    ? ColumnDefinitions 5      ?? 5      ?? 5      .+?5      ? $??0??6   .+?5        OxyPlot.Wpf.Plot     Title$ Lab 3 Task 2??6      Series 5        OxyPlot.Wpf.LineSeries  5        OxyPlot.Wpf.Series   Color$
 #00f??6G   ??6)   ?? *Orig2+6G     5      $
 #f00??6F   ??6)   ?? *Res2+6F   5      5      ? 5      $??1??6   .+?5      ?? -   5         ??Name$ task2Spectr??5       ?? TextWrapping$
 Wrap=?60    ?? AcceptsReturn$
 True??6D   $	 ?? HorizontalScrollBarVisibility$	 Visible=?6Y   5       5!      ? 5#   
   $??1??6    5$      ?? 5%      ?? 5&      .+?5(      ? $??0??6   .+?5)        $ Lab 3 Task 3??6    5*        5+      $
 #00f??6G   ??6)   ?? *Orig3+6G     5,      $
 #f00??6F   ??6)   ?? *Res3+6F     5-      $
 #700??6S   ??6)   ?? *Res3WithoutPhases+6S   5/      50      ? 51      $??1??6   .+?52      ?? -   5        $ task3Spectr??52      $
 Wrap=?60   $
 True??6D   $	 Visible=?6Y   53      54      ? 55   
   $??2??6    56      ?? 57      ?? 58      .+?5:      ? $??0??6   .+?5;        $ Lab 3 Task 4-5??6    5<        5=      $
 #00f??6H   ??6)   ?? *Orig45+6H     5>      $
 #f00??6G   ??6)   ?? *Res45+6G   5@      5A      ? 5B      $??1??6   .+?5C      ?? -   5        $ task45Spectr??5C      $
 Wrap=?61   $
 True??6E   $	 Visible=?6Z   5D      5E      ? 5F   
   $??3??6    5G      ?? 5H      ?? 5I      ?? 5J      .+?5L      ? $??0??6    5M      ?? 5N      ?? 5O      .+?5Q      	? -   5        $??0??5Q      
 	? 	GroupName$
 sinals??6+   $??Model signal (from lab4)??6>    d? 	IsChecked$
 TrueY?6a   6r   	? 5R      -   5        $??1??5R      $
 sinals??6+   $??Real signal (lightning)??6>   6`   5S      ?? 5T      -   5        $??1??5T      $??Запустить ЛР 3??6%   $??36(?6S   ? 5U      $??2??6    5V      ?? 5W      ?? 5X      .+?5Z      ?? -   5        $ freqFrom??5Z      $??0??6,   $
??36px(?6<   $??0??6L   ?? 5[      -   5        $ freqTo??5[      $??1??6*   $
??36px(?6:   $??0??6J   5\      5]      5^      5_      