   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjektWPF.ZawodyProjektWPF.Zawody  5   	   *    $ProjektWPF.Zawody.AddDruzynaDoZawody   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProjektWPF.Zawody     5   	     � Title$  AddDruzynaDoZawody��5   	   $	��400��6$   $	��350��61   $��16(�6=    � 	Resources 5	         szablon �� 
TargetType �� CornerRadius �� StrokeDashArray �� StrokeDashCap J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value  GroupTemplate �� Padding �� Path  GroupTemplate2��%�  &	        &	 B    &	 �    �� 5
   
   " ��6*   .R�5      �� $��Border��6   
��� d �$��3q�6;   $ 0 0 4 4��5      
���2͚�
���   �._�5      � .+�5      �� $��FocusCue��6    $y� Hidden=�60   
���   �$��3��5   0   $	 1 2R�5       $ Round=�67   $
 True��5       �� 5      $
��True��6'   #��z��5   '   5      5       5      P� 5       �@J�IsMouseOver$
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
 ���p�5'      5(      5+      �� 5-   
   .R�5.      �� $
��Bold"�5/      
�������
���   �$��0,5,0,0q�50   $   $ 3q�51      ��5.      �� $
 Name�51      52      �� 53   
   .R�54      �� $
��Bold"�55      
�������
���   �$��0,5,0,0q�56   $   $ 3q�57      ��54      �� $ Nazwa�57      58      59      .��5:      � -   5        $��Zawdruz��5:       � ColumnDefinitions 5;   
   �� 5<      $��* �6   �� 5=      $��* �6    � RowDefinitions 5?   
   �� 5@      $��* �6   �� 5A      $��* �6   �� 5B      $��* �6   �� 5C      $��* �6   �� 5D      $��* �6   �� 5E      $��* �6   �� 5F      $��* �6   .+�5H   
   �� $0��*Czy jesteś pewny aby dodać tę drużynę��6   $��2��6@   $��Center=�6T   6s   �� 5I   
   -   5        $��lista_druzyn��5I      $��3��6&   $��1��67   $��2��6D   $��5q�6X   $��Visible=�5J      6F   �� 5L   
   $��2��6   $��Center=�6$   $��4��6A   $��Do tych zawodów?��6N   6k   �� 5N   
   $��5��6   $��0��6   $��5q�6-   $��Nazwa drużyny:��68   6S   �� 5O   
   -   5        $��NazwaTextbox��5O   8   $��5��6   $��1��6   $��5q�6-   ��5P      �� $ Nazwa�63   �� 5R   
   -   5        $��	AddButton��5R   i   #��[  6   $��6��65   $��0��6B   $��5q�6R   .��5S      Dodaj6   �� 5T   
   -   5        #��[  5T      $��6��65   $��1��6B   $��5q�6R   .��5U      Anuluj6   5V      5W      