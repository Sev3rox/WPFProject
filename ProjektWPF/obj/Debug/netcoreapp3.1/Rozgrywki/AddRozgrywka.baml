   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ProjektWPF.RozgrywkiProjektWPF.Rozgrywki  5   	   '    !ProjektWPF.Rozgrywki.AddRozgrywka   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ProjektWPF.Rozgrywki     5   	     � Title$  AddRozgrywka��5   	   $	��800��6   $	��600��6+   $��16(�68    � 	Resources 5	         szablon �� 
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
 ���p�5'      5(      5+      5,      .��5-      � -   5        $��AddGrid��5-       � ColumnDefinitions 5.   
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
��auto �6   �� 5<      $��* �6   �� 5=      $
��auto �6   .+�5?   
   �� $��5q�6   .��6   Drużyna 1:6'   �� 5A      $��1��6   $��5q�6"   .��6-   Drużyna 2:69   �� 5B   
   $��Center=�6   $��2��6,   $��5q�69   .��6D   Data:6K   �� 5C   
   $��Center=�6   $��3��6,   $��5q�69   .��6D   
Godzina:6N   �� 5E   
   $��4��6   $��5,5,80,5q�6   .��6/   
Miejsce:69   �� 5F   
   $��5��6   $��5,5,80,5q�6   .��6/   
Turniej:69   �� 5G   
   $��6��6   $��5,5,80,5q�6   .��6/   Opis:66   �� 5H   
   $��5,25,5,5q�6   $��Center=�6'    �� Orientation$ 
Horizontal=�6D   $��7��6]   $��2��6j   .+�5J      �� $��Center=�6   $��5,5,50,5q�64   .+�5K      �� $��Center=�6   $��5q�6<   $��Sędzia główny:��6G   6b   �� 5L      -   5        $��SedziaglownyTextBox��5L   ?   $��Center=�6[   $��5q�6   ��6�   ��  �� Path$ Sedziaglowny� �� ValidatesOnDataErrors$
 True�� �� NotifyOnValidationError$
 True��6�   5M      �� 5N      $��5,5,50,5q�6   .+�5O      �� $��Center=�6   $��5q�6<   $��Sędziowie pomocniczy:��6G   6i   �� 5P      $��Center=�6   $��5q�6>   ��6I   �� $ 
Sedziapom1�6m   �� 5Q      $��Center=�6   $��5q�6?   ��6J   �� $ 
Sedziapom2�6n   5R      �� 5S      $��5,5,5,5q�6   $��Center=�6*   .+�5T      �� $��Center=�6   $��5q�6<   $��Sędzia techniczny:��6G   6f   �� 5U      $��Center=�6   $��5q�6>   ��6I   �� $ Sedziatechniczny�6s   5V      5X      �� 5_   
   -   5        $��Team1��5_      $��1��6    $��5q�60   5a      �� 5c   
   -   5        $��Team2��5c      $��1��6    $��1��6.   $��5q�6>   5e      &   System.Windows.Controls.Calendar  5f   
   -   5        $��DateCalendar��5f      $��5q�6   $��1��62   $��2��6B      SelectedDate 6O   �� $
 Date�$
 True��$
 True��6�   �� 5g   
   -   5        $��HourTextBox��5g   E   $��Center=�6Y   $��1��6{   $��3��6�   $��5q�6�   ��6�   �� $
 Hour�$
 True��$
 True���� 5h   
   -   5        $��PlaceTextBox��5h   ;   $��1��6O   $��4��6_   $��5q�6l    �� SelectedIndex$ 0��6w    �� Text 6�   �� $ Place�$
 True��$
 True��.@�5i      �� .��6    Stadion Miejski w Białymstoku6:   �� 5j      .��6   &$Drugi Stadion Miejski w Białymstoku6@   �� 5k      .��6   Stadion Miejski w Suwałkach68   �� 5l      .��6   Stadion Miejski w Łomży64   �� 5m      .��6   %#Stadion Miejski w Bielsku Podlaskim6@   �� 5n      .��6   Stadion Miejski w Zambrowie69   �� 5o      .��6   '%Stadion Miejski w Wysokim Mazowieckiu6B   �� 5p      .��6   Stadion Miejski w Grajewie67   5q      �� 5r   
   $��1��6   $��5��6"   $��5q�6/   ��6:   �� $ Turniej��� 5s   
   $��Center=�6   $��1��65   $��6��6E   $��5q�6R   ��6]   �� $
 Opis�� 5t   
   $��9��6   $��1��6   $��2��6-    5u      �� 5v      �� 5w      �� 5x      .+�5z      �� $��0��6   $��15,15,15,15q�6%   ��6;   �� $ SelectedItem.ImagePath� �� ElementName$ Team1��6   �� 5{      $��1��6   $��20q�6&   $��../Files/vs.jpg��63    J� RenderTransformOrigin$ 0.5,0.5&�6M   z�5|      �� 5}      -   5        MyAnimatedTransform�� �� Angle$ 0Q�5}   C    � Triggers 5      :� 5�       :� RoutedEvent$ Image.Loaded��6#   .[�5�      �� .��5�      �� .��5�   "   W�  �� 
TargetName$ MyAnimatedTransform��5�       �� TargetProperty$ (RotateTransform.Angle)�5�       W� From 0.05�      	 W� To 3606    g� Duration$ 0:0:6D�6%     g� RepeatBehavior$  Forever��66   5�      5�      5�      5�      �� 5�      $��2��6   $��15,15,15,15q�6&   ��6=   �� $ SelectedItem.ImagePath�$ Team2��6�   5�      �� 5�   
   $��Center=�6   $ 
Horizontal=�62   $��10��6L   $��2��6Z   .+�5�      �� -	   5        #��[  5�      $��10,10,60,10q�6E   $
��20,6q�6Z   .��6i   Dodaj6p   �� 5�      -
   5        #��[  5�      $��10q�6H   $
��20,6q�6T   .��6c   Anuluj6k   5�      5�      5�      