   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjektWPF.WynikiProjektWPF.Wyniki  5   	   #    ProjektWPF.Wyniki.FiltrWyniki   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProjektWPF.Wyniki     5   	     � Title$  FiltrWyniki��5   	   $	��440��6   $	��430��6*   $��16(�66    � 	Resources 5	         szablon �� 
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
 ���p�5'      5(      5+      5,      .��5-      � -   5        $��	FiltrGrid��5-       � ColumnDefinitions 5.   
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
��auto �6   �� 5;      $��* �6   �� 5<      $
��auto �6   .+�5?   
   �� $��4��6   $��5q�6   .��6(   
Miejsce:62   �� 5@   
   $��5��6   $��5q�6   .��6(   
Sędzia:61   � 5B   
   $��8��6   $��1��6   $��2��6-    5C      �� 5D      �� 5E      �� 5F      .+�5H      �� $��0��6   $��10,10,10,10q�6%   ��6;   ��  �� Path$ SelectedItem.ImagePath� �� ElementName$ Team1��6   �� 5I      $��1��6   $��10q�6&   $��../Files/vs.jpg��63   6O   �� 5J      $��2��6   $��10q�6&   ��64   �� $ SelectedItem.ImagePath�$ Team2��6x   5K      �� 5M   
   $��5q�6   .��6   Drużyna 1:6'   �� 5O   
   $��1��6   $��5q�6   .��6)   Drużyna 2:65   �� 5P   
   $��7��6   $��5q�6   .��6)   Drużyna wygrana:6;   �� 5Q   
   -   5        $	��Won��5Q      $��1��6   $��5q�6/    �� SelectedIndex$ 0��6:   $��7��6L   �� 5S   
   -   5        $��Team1��5S      $��1��6!   $��5q�61   $ 0��6<   6N   �� 5V   
   -   5        $��Team2��5V      $��1��6    $��1��6.   $��5q�6>   $ 0��6I   6[   �� 5X   
   $��1��6   $��4��6#   $��5q�60   $ 0��6;    �� Text 6M   �� $ Place��� 5Y   
   $��5q�6   $��5��6   $��1��6*   ��6:   �� $ Sedziaglowny�6_   �� 5Z   
   $��Center=�6    �� Orientation$ 
Horizontal=�62   $��9��6L   $��2��6Y   .+�5[      �� -   5        #��[  5[      $��10,10,40,10q�6:   $
��20,6q�6O   .��6l   Zastosuj Filtr6|   �� 5\      -   5        #��[  5\      $��10q�6:   $
��20,6q�6F   .��6c   Zresetuj Filtr6s   5]      5^      5_      