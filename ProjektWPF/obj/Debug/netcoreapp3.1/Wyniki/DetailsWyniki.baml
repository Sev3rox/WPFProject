   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjektWPF.WynikiProjektWPF.Wyniki  5   	   %    ProjektWPF.Wyniki.DetailsWyniki   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProjektWPF.Wyniki     5   	     � Title$  DetailsWyniki��5   	   $	��750��6   $	��600��6,   $��16(�68    � 	Resources 5	         szablon �� 
TargetType �� CornerRadius �� StrokeDashArray �� StrokeDashCap J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value��%b  &	        �� 5
   
   " ��6*   .R�5      �� $��Border��6   
��� d �$��3q�6;   $ 10 10 10 10��5      
���2͚�
���   �._�5      � .+�5      �� $��FocusCue��6    $y� Hidden=�60   
���   �$��3��5   0   $	 1 2R�5       $ Round=�67   $
 True��5       �� 5      $
��True��6'   $��Center=�6B   #��z��5   '   5      5       5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      �� $
 Border��6    � ��
 � ���5      5      P� 5       � ��$
	 True��6/   . �5      �� $
 Border��6    � ��
 � d �5      �� 5      $
 Border��6    � ��
 �2͚�5       5!      P� 5"       � {�$	 False��6/   . �5#      �� $
 Border��6    � ��
 �����5%      �� 5&      $
 Border��6    � ��
 ���p�5'      5(      5+      5,      .��5-      � -   5        $��DetailsGrid��5-       � ColumnDefinitions 5.   
   �� 5/      $
��auto �6   �� 50       � RowDefinitions 52   
   �� 53      $
��auto �6   �� 54      $
��auto �6   �� 55      $
��auto �6   �� 56      $
��auto �6   �� 57      $
��auto �6   �� 58      $
��auto �6   �� 59      $
��auto �6   �� 5:      $
��auto �6   �� 5;      $
��auto �6   �� 5<      $
��auto �6   �� 5=      $��* �6   �� 5>      $
��auto �6   .+�5@   
   �� $��5q�6   .��6   Drużyna 1:6'   �� 5A   
   $��1��6   .+�5B      �� $��5q�6   .��6    Drużyna 2:6,   �� 5C      $��5q�6   .��6    Data:6'   5D      �� 5E   
   $��2��6   $��5,5,80,5q�6   .��6/   
Miejsce:69   �� 5F   
   $��3��6   $��5,5,80,5q�6   .��6/   
Turniej:69   �� 5G   
   $��4��6   $��5,5,80,5q�6   .��6/   Opis:66   �� 5H   
   $��5,25,5,5q�6   $��Center=�6'    �� Orientation$ 
Horizontal=�6D   $��5��6]   $��2��6j   .+�5J      �� $��Center=�6   $��5,5,50,5q�64   .+�5K      �� $��Center=�6   $��5q�6<   $��Sędzia główny:��6G   6b   �� 5L      -   5        $��
SedziaGlow��5L   H   $��Center=�6   $��5q�6=   6\   5M      �� 5N      $��5,5,50,5q�6   .+�5O      �� $��Center=�6   $��5q�6<   $��Sędziowie pomocniczy:��6G   6i   �� 5P      -   5        $��Sedziepom11��5P   G   $��Center=�6   $��5q�6<   6\   �� 5Q      -   5        $��Sedziepom22��5Q   H   $��Center=�6   $��5q�6=   6]   5R      �� 5S      $��5,5,5,5q�6   $��Center=�6*   .+�5T      �� $��Center=�6   $��5q�6<   $��Sędzia techniczny:��6G   6f   �� 5U      -   5        $��
Sedziatech��5U   G   $��Center=�6   $��5q�6<   6[   5V      5X      �� 5Y   
   $��6��6   $��Wynik:��6   $��5q�6.   6;   �� 5Z   
   $��1��6   $��6��6%   $��5q�62   $ 
Horizontal=�6=   .+�5[      �� -   5        $��Team11��5[      $��Infinity Białystok��6"   6A   �� 5\      $��Center=�6   $��1��66   $ 
Horizontal=�6C   $��1��6\   $��1��6l   .+�5]      �� -   5        $��WynikTextBox1��5]   q   $��Center=�6�   $��5q�6�   ��6   ��  �� Path$ Wynik1� �� ValidatesOnDataErrors$
 True�� �� NotifyOnValidationError$
 True��6�   �� 5^      $��:��6   $��Center=�6%   $��5q�6G   6T   �� 5_      -   5        $��WynikTextBox2��5_   q   $��Center=�6�   $��5q�6�   ��6   �� $ Wynik2�$
 True��$
 True��6�   5`      �� 5a      -	   5        $��Team22��5a      $��Regional Triangles��6"   6A   5b      �� 5j   
   -
   5        $��Team1��5j   -   $��1��6   $��5q�6!   6-   �� 5k   
   $��1��6   $��1��6%   .+�5l      �� -   5        $��Team2��5l   <   $��5q�6   $��Regional Triangles��6   6<   �� 5m      -   5        $
��Data��5m      $��5q�6   6   5n      �� 5o   
   -   5        $��Miejsce��5o   8   $��1��6   $��2��6    $��5q�6-   68   �� 5p   
   -   5        $��Turniej��5p   8   $��1��6   $��3��6    $��5q�6-   68   �� 5q   
   -   5        $
��Opis��5q   8   $��1��6   $��4��6    $��5q�6-   68   � 5r   
   $��9��6   $��1��6   $��2��6-    5s      �� 5t      �� 5u      �� 5v      .+�5x      �� -   5        $��Image1��5x      $��0��6"   $��10,10,10,10q�63   $��../Files/eeee.jpg��6I   6f   �� 5y      $��1��6   $��10q�6&   $��../Files/eeee.jpg��63   6Q   �� 5z      -   5        $��Image2��5z      $��2��6#   $��10q�64   $��../Files/eeee.jpg��6B   6_   5{      �� 5   
   #��[  6   $��10q�65   $
��60,6q�6A   $��18(�6P   $��Center=�6_   $��0��6|   $��2��6�   $��10��6�   .��6�   	Zamknij6�   5�      5�      