   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjektWPF.WynikiProjektWPF.Wyniki  5   	   !    ProjektWPF.Wyniki.AddWyniki   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProjektWPF.Wyniki     5   	     � Title$  	AddWyniki��5   	   $	��170��6   $	��600��6(    � 	Resources 5	         szablon �� 
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
 ���p�5'      5(      5+      5,      .��5-      � -   5        $��AddGrid��5-       � RowDefinitions 5.   
   �� 5/      $
��auto �6   �� 50      �� 51       � ColumnDefinitions 53   
   �� 54      $
��auto �6   �� 55      .+�57   
   �� $��5q�6   $��18(�6   $��Mecz:��6)   6;   �� 58   
   -   5        $
��Mecz��58      $��5q�6   $��18(�6*   $��1��68    �� SelectedIndex$ 0��6H   59      �� 5:   
   $��5q�6   $��18(�6   $��Wynik��6)   $��1��69   6H   �� 5;   
   $��Center=�6   $��1��62    �� Orientation$ 
Horizontal=�6?   $��1��6X   $��1��6h   .+�5<      �� -   5        $��WynikTextBox1��5<   �   $��Center=�6�   $��5q�6�   ��6   ��  �� Path$ Wynik1� �� ValidatesOnDataErrors$
 True�� �� NotifyOnValidationError$
 True��6�   �� 5=      $��:��6   $��Center=�6!   $��5q�6C   6P   �� 5>      -   5        $��WynikTextBox2��5>   �   $��Center=�6�   $��5q�6�   ��6   �� $ Wynik2�$
 True��$
 True��6�   5?   
   �� 5@   
   $��Center=�6   $��2��62   $ 
Horizontal=�6?   $��2��6X   .+�5A      �� -   5        #��[  5A      $��18(�69   $��	10,0,60,0q�6H   $
��20,6q�6[   .��6v   Dodaj6}   �� 5B      -   5        #��[  5B      $��18(�69   $��0q�6H   $
��20,6q�6S   .��6r   Anuluj6z   5C      5D      5E      