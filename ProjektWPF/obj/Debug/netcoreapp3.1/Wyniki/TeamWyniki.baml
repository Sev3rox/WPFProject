   M S B A M L   `   `   `  ����E  AProjektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ProjektWPF.WynikiProjektWPF.Wyniki  5   	   "    ProjektWPF.Wyniki.TeamWyniki   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ProjektWPF.Wyniki     5   	     � Title$  
TeamWyniki��5   	   $	��480��6   $	��400��6)    � 	Resources 5	         szablon �� 
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
 ���p�5'      5(      5+      5,      .��5-      �  � ColumnDefinitions 5.   
   �� 5/      $��* �6   �� 50      $��* �6    � RowDefinitions 52   
   �� 53      $
��auto �6   �� 54      �� 55      $
��auto �6   .+�57   
   �� -   5        $��Team1��57      6   �� 58   
   -   5        $��Team2��58      $��1��6   6/   �� 59   
   -   5        $��lista1��59      $��0��6    $��1��60   $��5,4.2,5.2,5.6q�6=   $��Visible=�5:   &   ��59   T   ��  �� Path$ lista_zawodnikow�5:   [   �� 5;   
   -   5        $��lista2��5;      $��1��6    $��1��60   $��5,4.2,5.2,5.6q�6=   $��Visible=�5<   &   ��5;   T   �� $ lista_zawodnikow�5<   [   �� 5=   
   -   5        #��[  5=      $��10q�65   $
��10,6q�6A   $��18(�6P   $��Center=�6_   $��0��6|   $��2��6�   $��10��6�   .��6�   	Zamknij6�   5>      5?      