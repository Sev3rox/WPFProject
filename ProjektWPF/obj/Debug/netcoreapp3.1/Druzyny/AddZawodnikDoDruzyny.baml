   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjektWPF.DruzynyProjektWPF.Druzyny  5   	   -    'ProjektWPF.Druzyny.AddZawodnikDoDruzyny   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ProjektWPF.Druzyny     5   	     � Title$  AddZawodnikDoDruzyny��5   	   $	��400��6&   $	��350��63   $��16(�6?    � 	Resources 5	         szablon �� 
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
 ���p�5(      5)      5,      5-      .��5.      � -   5        $��Zawdruz��5.       � ColumnDefinitions 5/   
   �� 50   
   $��* �6   �� 51   
   $��* �6    � RowDefinitions 53      �� 54   
   $��* �6   �� 55   
   $��* �6   �� 56   
   $��* �6   �� 57   
   $��* �6   �� 58   
   $��* �6   �� 59   
   $��* �6   �� 5:   
   $��* �6   .+�5<   
   �� $1��+Czy jesteś pewny aby dodać tego zawodnika��6   $��2��6D   $��Center=�6X   6w   �� 5=   
   -   5        $��lista_zawodnikow��5=      $��3��6*   $��1��6;   $��2��6H   $��5q�6\    �� DisplayMemberPath$
 Dane��5>      $��Visible=�5?      6F   �� 5A      $��2��6   $��Center=�6    $��4��6=   $��Do tej drużyny?��6J   6f   �� 5C      $��5��6   $��0��6   $��5q�6)   $��Nazwa drużyny:��64   6O   �� 5D   
   -   5        $��NazwaTextbox��5D   8   $��5��6   $��1��6   $��5q�6-   ��5E      ��  �� Path$ Nazwa�63   �� 5G      -   5        $��6��5G      $��0��6   $��5q�6*   #��[  5H      .��61   Dodaj68   �� 5I      -   5        $��6��5I      $��1��6   $��5q�6*   #��[  5J      .��61   Anuluj69   5K      5L      