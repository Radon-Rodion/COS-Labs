   M S B A M L   `   `   `  ????C  ?COS_Lab4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:COS_Lab4COS_Lab4  5   	       COS_Lab4.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NOxyPlot.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:COS_Lab4     5   	     ? Title$  
MainWindow??5	   	   $	??450??6   $	??800??6)   .??5
      ?  ? RowDefinitions 5   
   ?? 5      $
??100* ?6   ?? 5      $
??100* ?6   ?? 5      $
??110* ?6   ?? 5      $??50 ?6   .+?5   
   ? $??0??6    ? ColumnDefinitions 5      ?? 5      ?? 5      .+?5      ? $??0??6   .+?5        OxyPlot.Wpf.Plot     Title$ Lab 4??6      Series 5        OxyPlot.Wpf.LineSeries  5        OxyPlot.Wpf.Series   Color$
 #00f??6F   ??6)   ?? *Orig+6F     5      $
 #f00??6H   ??6)   ?? *Middle+6H     5      $
 #0f0??6J   ??6)   ?? *
Parabola+6J     5      $
 #990??6H   ??6)   ?? *Median+6H   5      5      ? 5       $??1??6   .+?5!      ?? -   5         ??Name$ middleSpectr??5!       ?? TextWrapping$
 Wrap=?61    ?? AcceptsReturn$
 True??6E   $	 ?? HorizontalScrollBarVisibility$	 Visible=?6Z   5"      5#      ? 5%   
   $??1??6    5&      ?? 5'      ?? 5(      .+?5*      ? $??0??6   .+?5+      ?? -   5        $ 
origSpectr??5+      $
 Wrap=?6/   $
 True??6C   $	 Visible=?6X   5,      ? 5-      $??1??6   .+?5.      ?? -   5        $ parabolaSpectr??5.      $
 Wrap=?63   $
 True??6G   $	 Visible=?6\   5/      50      ? 51   
   $??2??6    52      ?? 53      ?? 54      .+?56      ? $??1??6   .+?57      ?? -   5        $ medianSpectr??57      $
 Wrap=?61   $
 True??6E   $	 Visible=?6Z   58      59      ? 5:   
   $??3??6    5;      ?? 5<      ?? 5=      ?? 5>      .+?5@      ? $??0??6    5A      ?? 5B      ?? 5C      5F      ?? 5G      -   5        $??1??5G      $??Запустить ЛР 4??6%   $??36(?6?   6M   ? 5H      $??2??6    5I      ?? 5J      ?? 5K      5M      5N      5O      5P      