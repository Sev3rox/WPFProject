   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjektWPF.DruzynyProjektWPF.Druzyny  5   	   &     ProjektWPF.Druzyny.DeleteDruzyna   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ProjektWPF.Druzyny     5   	     � Title$  DeleteDruzyna��5   	   $	��135��6   $	��400��6,    � 	Resources 5	         szablon �� 
TargetType �� CornerRadius �� StrokeDashArray �� StrokeDashCap J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value��%P  &	        �� 5
   
   " ��6*   .R�5      �� $��Border��6   
��� d �$��3q�6;   $ 10 10 10 10��5      
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
 ���p�5'      5(      5+      5,      .��5-      �  � RowDefinitions 5.   
   �� 5/      $
��auto �6   �� 50      .+�53   
   �� $��5q�6   $��18(�6   .��6*   -+Czy na pewno chcesz usunąć tą drużynę?6R   �� 54   
   $��Center=�6   $��2��62    �� Orientation$ 
Horizontal=�6?   .+�55      �� -   5        $��18(�55      $��5,5,80,5q�60   $��Center=�6B   #��[  56      $��Center=�69   .��6[   Usuń6a   �� 57      -   5        $��18(�57      $��5q�62   $��Center=�6=   #��[  58      $��Center=�69   .��6[   Anuluj6c   5:      5;      5<      