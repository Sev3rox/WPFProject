   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ProjektWPF.ZawodnicyProjektWPF.Zawodnicy  5   	   )    #ProjektWPF.Zawodnicy.FilterZawodnik   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ProjektWPF.Zawodnicy     5   	     � Title$  FilterZawodnik��5   	   $	��385��6    $	��360��6-   $��16(�69    � 	Resources 5	         szablon �� 
TargetType �� CornerRadius �� StrokeDashArray �� StrokeDashCap J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value��%x  &	        �� 5
   
   " ��6*   .R�5      �� $��Border��6   
��� d �$��3q�6;   $ 10 10 10 10��5      
���2͚�
���   �._�5      � .+�5      �� $��FocusCue��6    $y� Hidden=�60   
���   �$��3��5   0   $	 1 2R�5       $ Round=�67   $
 True��5       �� 5      $
��True��6'   $��Center=�6B   $��Center=�5   '   #��z��5   '   5      5       5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      �� $
 Border��6    � ��
 � ���5      5      P� 5       � ��$
	 True��6/   . �5      �� $
 Border��6    � ��
 � d �5      �� 5       $
 Border��6    � ��
 �2͚�5!      5"      P� 5#       � {�$	 False��6/   . �5$      �� $
 Border��6    � ��
 �����5&      �� 5'      $
 Border��6    � ��
 ���p�5(      5)      5,      5-      .��5.      � -   5        $��	FiltrGrid��5.       � ColumnDefinitions 5/   
   �� 50      $
��auto �6   �� 51       � RowDefinitions 53   
   �� 54      $
��auto �6   �� 55      $
��auto �6   �� 56      $
��auto �6   �� 57      $
��auto �6   �� 58      $
��auto �6   �� 59      $
��auto �6   �� 5:      $
��auto �6   �� 5;      $��* �6   �� 5<      $
��auto �6   .+�5?   
   �� $��2��6   $��5q�6   .��6(   Wiek:6/   �� 5A   
   $��4��6   $��5q�6   .��6(   
Pozycja:62   �� 5B   
   $��5��6   $��5,5,30,5q�6   .��6/   Numer:67   �� 5C   
   $��Center=�6   $��20q�62    �� Orientation$ 
Horizontal=�6>   $��6��6W   $��2��6d   .+�5D      �� $��5,5,80,5q�6:    d� 	IsChecked 6   ��  �� Path$ Leftleg�.��6L   
Lewonożny6W   �� 5E      $��5q�6<    6   �� $ Rightleg�.��6G   Prawonożny6S   5F      �� 5G   
   $��Center=�6   $��0q�62   $ 
Horizontal=�6=   $��7��6V   $��2��6c   .+�5I      �� -   5        $��Teams��5I      $��33q�6(    �� SelectedIndex$ 0��64   5K      �� 5L      ��6   �� $ SelectedItem.ImagePath� �� ElementName$ Teams��6Y   5O      �� 5S      $��1��6   $��2��6&   $��5q�63   ��6>   �� $	 Age��� 5T   
   $��1��6   $��4��6#   $��5q�60   $ 0��6;    �� Text 6M   �� $ Position�.@�5U      �� .��6   	Napastnik6'   5V      �� 5W   
   $��1��6   $��5��6"   $��5q�6/   ��6:   �� $ Number��� 5X   
   $��Center=�6   $ 
Horizontal=�62   $��8��6L   $��2��6Y   .+�5Y      �� -   5        #��[  5Y      $��10,10,40,10q�6G   $
��20,6q�6\   .��6k   Zastosuj Filtr6{   �� 5Z      -   5        #��[  5Z      $��10q�6G   $
��20,6q�6S   .��6b   Zresetuj Filtr6r   5[      5\      5]      