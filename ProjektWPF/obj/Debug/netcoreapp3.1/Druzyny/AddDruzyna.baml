   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ProjektWPF.DruzynyProjektWPF.Druzyny  5   	   #    ProjektWPF.Druzyny.AddDruzyna   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ProjektWPF.Druzyny     5   	     � Title$  
AddDruzyna��5   	   $
��auto��6   $	��420��6*   $��16(�5	   	    � 	Resources 5
         szablon �� 
TargetType �� CornerRadius �� StrokeDashArray �� StrokeDashCap J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value��%x  &	        �� 5   
   " ��6*   .R�5      �� $��Border��6   
��� d �$��3q�6;   $ 10 10 10 10��5      
���2͚�
���   �._�5      � .+�5      �� $��FocusCue��6    $y� Hidden=�60   
���   �$��3��5   0   $	 1 2R�5       $ Round=�67   $
 True��5       �� 5      $
��True��6'   $��Center=�6B   $��Center=�5   '   #��z��5   '   5      5       5      P� 5       �@J�IsMouseOver$
	 True��61   . �5      �� $
 Border��6    � ��
 � ���5      5      P� 5       � ��$
	 True��6/   . �5      �� $
 Border��6    � ��
 � d �5       �� 5!      $
 Border��6    � ��
 �2͚�5"      5#      P� 5$       � {�$	 False��6/   . �5%      �� $
 Border��6    � ��
 �����5'      �� 5(      $
 Border��6    � ��
 ���p�5)      5*      5-      5.      .��5/      � -   5        $��AddDruzGrid��5/       � ColumnDefinitions 50   
   �� 51      $
��auto �6   �� 52       � RowDefinitions 54   
   �� 55      $
��auto �6   �� 56      $
��auto �6   �� 57      $
��auto �6   �� 58      $
��auto �6   �� 59      $��* �6   �� 5:      $
��auto �6   �� 5;      $
��auto �6   �� 5<      $
��auto �6   �� 5=      $
��auto �6   .+�5?   
   �� $��5q�6   .��6   Nazwa:6#   �� 5@   
   $��1��6   $��5q�6   .��6(   Kraj pochodzenia:6;   �� 5A   
   $��2��6   $��5q�6   $��	Siedziba:��6(   �� 5B   
   $��3��6   $��5,5,75,5q�6   .��6/   
Sukcesy:69   �� 5C   
   $��4��6   $��5q�6   .��6(   Logo:6/   �� 5D   
   -   5        $��5��5D      $�� 5q�6   $��5q�6@   #��[  5E      .��65   Search6=   �� 5F   
   $��6��6   $��5q�6   .��6(   
Sponsorzy:64   �� 5G   
   $��7��6   $��5q�6   .��6(   Właściciel:65   �� 5I   
   -   5        $��NazwaTextBox��5I   R   $��Center=�6   $��1��6f   $��5q�6v   ��6�   ��  �� Path$ Nazwa� �� ValidatesOnDataErrors$
 True�� �� NotifyOnValidationError$
 True���� 5J   
   -   5        $��KrajTextBox��5J   Q   $��Center=�6   $��1��6d   $��1��6t   $��5q�6�   ��6�   �� $ Country�$
 True��$
 True���� 5K   
   -   5        $��SiedzibaTextBox��5K   U   $��Center=�6   $��1��6l   $��2��6|   $��5q�6�   ��6�   �� $
 City�$
 True��$
 True���� 5L   
   -   5        $��SukcesyTextBox��5L   5   $��Center=�6   $��1��6K   $��3��6[   $��5q�6h   ��6s   �� $ Succes�$
 True��$
 True��6�   �� 5M   
   -   5        $��
imgDynamic��5M      $��4��6"   $��2��6/   $��1��6@   $��5q�5N      $��Uniform=�6   ��6-   �� $ 	ImagePath�6Q   �� 5O   
   -   5        $��SponsorzyTextBox��5O   Q   $��6��6   $��1��6   $��Center=�6i   $��5q�6�   ��6�   �� $ Sponsors�$
 True��$
 True��6�   �� 5P   
   -	   5        $��WlasicielTextBox��5P   R   $��7��6   $��1��6   $��Center=�6j   $��5q�6�   ��6�   �� $ Owner�$
 True��$
 True��6�   �� 5Q   
   $��Center=�6    �� Orientation$ 
Horizontal=�62   $��8��6L   $��2��6Y   .+�5R      �� -
   5        $��10,10,60,10q�5R   !   $
��20,6q�66   #��[  5S      .��69   Dodaj6@   �� 5T      -   5        $��10q�5T   $   $
��20,6q�60   #��[  5U      .��69   Anuluj6A   5V      5W      5X      