   M S B A M L   `   `   `  ����S  OTheBestProjectInTheWorld, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:TheBestProjectInTheWorldTheBestProjectInTheWorld  5   	   a5clr-namespace:TheBestProjectInTheWorld.MVVM.ViewModel'TheBestProjectInTheWorld.MVVM.ViewModel  5   	   )    #TheBestProjectInTheWorld.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:TheBestProjectInTheWorld     5   	   K	viewModel5clr-namespace:TheBestProjectInTheWorld.MVVM.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��800��6   $
��1100��6)   ���#253659 � WindowStyle$ SingleBorderWindow=�5   	    � 
ResizeMode$ NoResize=�5   	    � DataContext 5      ;  5TheBestProjectInTheWorld.MVVM.ViewModel.MainViewModel  5   
   .��5      �� .+�5   
   � y�6   �� *
IsLogged+   	BoolToVis �� 	Converter# [   � RowDefinitions 5      �� 5      $��90 �6    �� 5       � ColumnDefinitions 5      �� 5      $	��274 �6#   �� 5      �� 5      $��89 �6#   .+�5      �� $��0��6   $��3��6&   $��90��5      ���#1B2B4E5      �� 5$      $��0��6   $��0��5%      $��/Images/Logo.png��5&      $��56��5'      $	��218��5(      	� 56      $��1��6     MenuButtonsTheme#��[ 57      $��	0,0,541,0q�58      $��ВОДИТЕЛИ��59      
������ $��16(�5;      $��0 0 0 1q�5<      
�������$	��190��5>       d� 	IsChecked$
 TrueY�5?      $��90��5A      ��5@      �� *DriversCommand+5A      	� 5C      $��1��6   $
��ВУ��5D      
������ $��0q�5F      $��16(�5G      
�������$	��170��5I      #��[ 5K      $��195,0,366,0q�6E   ��5J      �� *LicencesCommand+5K   E   	� 5M      $��1��6   $
��ТС��5N      
������ $��0q�5P      $��16(�5Q      
�������$	��170��5S      #��[ 5U      $��370,0,191,0q�6D   ��5T      �� *CarsCommand+5U   D   	� 5W      $��1��6   $��ДТП��5X      
������ $��0q�5Z      $��16(�5[      
�������$	��170��5]      #��[ 5^      $��
545,0,16,0q�6E   ��5_      �� *
DtpCommand+�� 5a      $��2��6   $��
ВЫЙТИ��5b      $��16(�5c      
�������
������ $��0q�5f       
 ButExt#��[ 5g      ��5h      �� *ExitCommand+5i      �� 5j   
   ��6   �� *CurrentView+5k      5l      