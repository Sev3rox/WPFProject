   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjektWPF.DruzynyProjektWPF.Druzyny  5   	   &     ProjektWPF.Druzyny.FilterDruzyna   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ProjektWPF.Druzyny     5   	     � Title$  FilterDruzyna��5   	   $	��180��6   $	��370��6,   $��16(�68    � 	Resources 5	         szablon �� 
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
 ���p�5(      5)      5,      5-      .��5.      � -   5        $��
FilterGrid��5.      $��0,0,0,-1q�6    � ColumnDefinitions 5/   
   �� 50      $
��auto �6   �� 51       � RowDefinitions 53   
   �� 54      $
��auto �6   �� 55      $
��auto �6   �� 56      $
��auto �6   .+�5;   
   �� $��0��6   $��5q�6   .��6(   Kraj:6/   �� 5<   
   $��1��6   $��5,5,30,5q�6   .��6/   	Siedziba:6:   �� 5>   
   $��1��6   $��0��6"   $��5q�6/   ��6:   ��  �� Path$ Country��� 5?   
   $��1��6   $��1��6"   $��5q�6/   ��6:   �� $
 City��� 5@   
   $��Center=�6    �� Orientation$ 
Horizontal=�62   $��8��6L   $��2��6Y   .+�5A      �� -   5        $��10,10,40,10q�5A   #   $
��20,6q�68   #��[  5B      .��69   Zastosuj Filtr6I   �� 5C      -   5        $��10q�5C   #   $
��20,6q�6/   #��[  5D      .��69   Zresetuj Filtr6I   5E      5F      5G      