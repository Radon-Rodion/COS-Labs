   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   R NOxyPlot.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   !localclr-namespace:WpfApp1  5   	     ? Title$  
MainWindow??5	   	   $	??450??6   $	??800??6)   .??5
      ?  ? RowDefinitions 5   
   ?? 5      $
??191* ?6   ?? 5      $	??26* ?6   .+?5   
   ? -   5         ?Name$ GrdMainPlot??5      $??Stretch=?6$   $??0??6C   $??Stretch=?6P   $
??Auto??6l   $
??Auto??6y   .+?5        OxyPlot.Wpf.Plot     Title 6   ?? *Title+   Series 5        OxyPlot.Wpf.LineSeries  5        OxyPlot.Wpf.Series   Color$
 #00f??6L   ??6%   ?? *NonNormalizedD+6L     5      $
 #000??6I   ??6%   ?? *NormalizedD+6I     5      $
 #f00??6G   ??6%   ?? *	Amplitude+6G     5      $
 #77f??6U   ??6%   ?? *NonNormalizedDWithPhase+6U     5      $
 #777??6R   ??6%   ?? *NormalizedDWithPhase+6R     5      $
 #f77??6P   ??6%   ?? *AmplitudeWithPhase+6P   5      5      ? 5   
   $??Center=?6   $??50??6,   $??2??69   $??Bottom=?6F   $	??958??6a   .+?5      ?? $
??Left=?6   $??80,3,0,0q?6/   $	??Top=?6A   $??22(?6Y   .??6h   N:6l   ?? 5      -   5         ??Name$ N??5      $
??1024??6!   $
??Left=?6-   $??	110,3,0,0q?6H   $	??Top=?6[   $??42??6s   $	??100??6   $??24(?6?   ?? 5      $
??Left=?6   $??	220,3,0,0q?6/   $	??Top=?6B   $??22(?6Z   .??6i   K:6m   ?? 5      -   5        $ K??5      $	??768??6!   $
??Left=?6,   $??	250,3,0,0q?6G   $	??Top=?6Z   $??42??6r   $	??100??6~   $??24(?6?   ?? 5       $
??Left=?6   $??	350,3,0,0q?6/   $	??Top=?6B   $??22(?6Z   .??6i   Phase:6q   ?? 5!      -   5        $ Phase??5!      $??0,392??6%   $
??Left=?62   $??	420,3,0,0q?6M   $	??Top=?6`   $??42??6x   $	??100??6?   $??24(?6?   ?? 5"      -   5         ??Name$
 Draw??5"      $??1??6#   $
??Draw??60   $??28(?6?   $
??Left=?6M   $??	535,3,0,0q?6h   $	??Top=?6{   $	??334??6?   6?   5#      5$      5%      