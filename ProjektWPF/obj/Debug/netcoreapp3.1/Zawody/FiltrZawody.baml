   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjektWPF.ZawodyProjektWPF.Zawody  5   	   #    ProjektWPF.Zawody.FiltrZawody   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProjektWPF.Zawody     5   	     � Title$  FiltrZawody��5   	   $	��400��6   $	��400��6*   $��16(�66    � 	Resources 5	         szablon �� 
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
���   �$��0,5,0,0q�56   $   $ 3q�57      ��54      �� $ Nazwa�57      58      59      .��5:      �  � ColumnDefinitions 5;   
   �� 5<      $
��auto �6   �� 5=       � RowDefinitions 5?   
   �� 5@      $
��auto �6   �� 5A      $
��auto �6   �� 5B      $
��auto �6   �� 5C      $
��auto �6   �� 5D      $
��auto �6   �� 5E      $
��auto �6   �� 5F      $
��auto �6   �� 5G      $��* �6   �� 5H      $
��auto �6   .+�5J   
   �� $��0��6   $��5q�6   .��6(   Miesiąc rozpoczęcia:6>   �� 5K   
   $��1��6   $��5q�6   .��6(   Miesiąc zakończenia:6>   �� 5L   
   $��2��6   $��5q�6   .��6(   Rok rozpoczęcia:6:   �� 5M   
   $��3��6   $��5,5,75,5q�6   .��6/   	Rodzaj:68   �� 5N   
   $��Center=�6   $��0q�62    �� Orientation$ 
Horizontal=�6=   $��7��6V   $��2��6c   �� 5Q   
   -   5        $��MiesiacStart��5Q   Q   $��Center=�6   $��1��65   $��5q�6E   6Q   �� 5R   
   -   5        $��MiesiacStop��5R   \   $��Center=�6   $��1��64   $��1��6D   $��5q�6Q   6\   �� 5S   
   -   5        $	��Rok��5S   \   $��Center=�6   $��1��64   $��2��6D   $��5q�6Q   6\   �� 5T   
   -   5        $��Rodzaj��5T   N   $��1��6   $��3��6#   $��5q�60    �� SelectedIndex$ -1��6;   .@�5U      �� .��6   Międzygminne6)   �� 5V      .��6   Międzymiastowe6+   5W      �� 5X   
   $��Center=�6   $ 
Horizontal=�62   $��8��6L   $��2��6Y   .+�5Y      �� -   5        #��[  5Y      $��10,10,60,10q�69   $
��20,6q�6N   .��6k   Filtr6r   �� 5Z      -   5        #��[  5Z      $��10q�69   $
��20,6q�6E   .��6b   Anuluj6j   5[      5\      5]      