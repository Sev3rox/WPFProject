   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjektWPF.DruzynyProjektWPF.Druzyny  5   	   $    ProjektWPF.Druzyny.EditDruzyny   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ProjektWPF.Druzyny     5   	     � Title$  EditDruzyny��5   	   $
��auto��6   $	��420��6+   $��16(�67    � 	Resources 5	         szablon �� 
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
 ���p�5'      5(      5+      5,      .��5-      � -   5        $��EditDruz��5-       � ColumnDefinitions 5.   
   �� 5/      $
��auto �6   �� 50       � RowDefinitions 52   
   �� 53      $
��auto �6   �� 54      $
��auto �6   �� 55      $
��auto �6   �� 56      $
��auto �6   �� 57      $��* �6   �� 58      $
��auto �6   �� 59      $
��auto �6   �� 5:      $
��auto �6   �� 5;      $
��auto �6   .+�5=   
   �� $��5q�6   .��6   Nazwa:6#   �� 5>   
   $��1��6   $��5q�6   .��6(   Kraj pochodzenia:6;   �� 5?   
   $��2��6   $��5q�6   .��6(   
Sziedziba:64   �� 5@   
   $��3��6   $��5q�6   .��6(   
Sukcesy:62   �� 5A   
   $��4��6   $��5q�6   .��6(   Logo:6/   �� 5B   
   -   5        $��5��5B      $�� 5q�6   $��5q�6@   #��[  5C      .��66   Search6>   �� 5D   
   $��6��6   $��5q�6   .��6(   
Sponsorzy:64   �� 5E   
   $��7��6   $��5q�6   .��6(   Właściciel:65   �� 5G   
   -   5        $��NazwaTextBox��5G      $��Center=�6D   $��1��6g   $��5q�6w   ��6�   ��  �� Path$ Nazwa� �� ValidatesOnDataErrors$
 True�� �� NotifyOnValidationError$
 True���� 5H   
   -   5        $��KrajTextBox��5H      $��Center=�6B   $��1��6d   $��1��6t   $��5q�6�   ��6�   �� $ Country�$
 True��$
 True���� 5I   
   -   5        $��SiedzibaTextBox��5I      $��Center=�6J   $��1��6l   $��2��6|   $��5q�6�   ��6�   �� $
 City�$
 True��$
 True���� 5J   
   -   5        $��SukcesyTextBox��5J      $��Center=�6(   $��1��6J   $��3��6Z   $��5q�6g   ��6r   �� $ Succes�6�   �� 5K   
   -   5        $��
imgDynamic��5K      $��4��6"   $��2��6/   $��1��6@   $��5q�5L      $��Uniform=�6   ��6-   �� $ 	ImagePath�6Q   �� 5M   
   -   5        $��SponsorzyTextBox��5M      $��6��6L   $��1��6Y   $��Center=�6i   $��5q�6�   ��6�   �� $ Sponsors�$
 True��$
 True��6�   �� 5N   
   -	   5        $��WlasicielTextBox��5N      $��7��6M   $��1��6Z   $��Center=�6j   $��5q�6�   ��6�   �� $ Owner�$
 True��$
 True��6�   �� 5O   
   $��Center=�6    �� Orientation$ 
Horizontal=�62   $��8��6L   $��2��6Y   .+�5P      �� -
   5        $��10,10,60,10q�5P   "   $
��20,6q�67   #��[  5Q      .��69   Edytuj6A   �� 5R      -   5        $��10q�5R   $   $
��20,6q�60   #��[  5S      .��69   Anuluj6A   5T      5U      5V      