   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjektWPF.ZawodyProjektWPF.Zawody  5   	   $    ProjektWPF.Zawody.DeleteZawody   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProjektWPF.Zawody     5   	     � Title$  DeleteZawody��5   	   $	��135��6   $	��360��6+    � 	Resources 5	         szablon �� 
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
���   �$��0,5,0,0q�56   $   $ 3q�57      ��54      �� $ Nazwa�57      58      59      .��5:      �  � RowDefinitions 5;   
   �� 5<      $
��auto �6   �� 5=      .+�5@   
   �� $��5q�6   $��18(�6   $-��'Czy na pewno chcesz usunąć te zawody?��6)   �� 5A   
   $��Center=�6   $��2��62    �� Orientation$ 
Horizontal=�6?   .+�5B      �� -   5        #��[  5B      $��18(�69   $
��10,3q�6H   $��5,5,80,5q�6W   .��6u   Usuń6{   �� 5C      -   5        #��[  5C      $��18(�69   $��5q�6H   $
��10,3q�6S   .��6q   Anuluj6y   5E      5F      5G      