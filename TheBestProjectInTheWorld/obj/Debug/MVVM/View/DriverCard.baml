   M S B A M L   `   `   `  ����S  OTheBestProjectInTheWorld, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:TheBestProjectInTheWorld.MVVM.View"TheBestProjectInTheWorld.MVVM.View  5      a5clr-namespace:TheBestProjectInTheWorld.MVVM.ViewModel'TheBestProjectInTheWorld.MVVM.ViewModel  6M   3    -TheBestProjectInTheWorld.MVVM.View.DriverCard   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:TheBestProjectInTheWorld.MVVM.View     5      K	viewmodel5clr-namespace:TheBestProjectInTheWorld.MVVM.ViewModel     6M   .��5	      ��   �� Orientation$  Vertical=�6   $
��1000��5
      $	��710��6   .+�5   
   �� $N��HЗаполение водительского удостоверения��6   $��30(�5      
�������$��0 0 0 5q�5      �� 5   
   $	��550��6   ���#1B2B4E �� CornerRadius$ 25��5      ._�5      �� $  Vertical=�6   $��Center=�5      $��Center=�5      .+�5      �� $  
Horizontal=�6   .+�5      �� $  Vertical=�6!   $��0 0 15 0q�68   .+�5      �� $��Дата создания��6$   
�������$��16(�5   $   $��0 0 0 10q�5   $   $��Center=�5   $   �� 5      $	��230��6"   $��30��5   "      LincenceView#��[  5    "   ��5!   "   �� *LicenceDate+5#      �� 5$      $  Vertical=�6!   .+�5%      �� $!��Дата окончания��6$   
�������$��16(�5'   $   $��0 0 0 10q�5(   $   $��Center=�5)   $   �� 5*      $	��230��6"   $��30��5+   "   #��[  5,   "   ��5-   "   �� *
ExpireDate+5/      51      �� 52      $  
Horizontal=�6   .+�53      �� $  Vertical=�6!   $��	0 15 15 0q�68   .+�55      �� $��Категория��6$   
�������$��16(�57   $   $��0 0 0 10q�58   $   $��Center=�59   $   �� 5:      $	��230��6"   $��30��5;   "   #��[  5<   "   ��5=   "   �� *
Categories+5?      �� 5@      $  Vertical=�6!   $��0 15 0 0q�68   .+�5A      �� $��Статус��6$   
�������$��16(�5C   $   $��0 0 0 10q�5D   $   $��Center=�5E   $   �� 5G      $	��230��6#   $��30��5H   #     ComboBoxLicence#��[ 5I   #    �� DisplayMemberPath$ 
StatusName��5L   #    �� SelectedItem 5J   #   �� *Status+��5K   #   �� *
Statuses+5M      5O      5Q      �� 5R      $  
Horizontal=�6   $��0 15 0 0q�67   .+�5S      �� $  Vertical=�6!   $��0 0 15 0q�68   .+�5U      �� $��
Серия��6$   
�������$��16(�5W   $   $��0 0 0 10q�5X   $   $��Center=�5Y   $   �� 5Z      $	��230��6"   $��30��5[   "   #��[  5\   "   ��5]   "   �� *LicenceSeries+5_      �� 5`      $  Vertical=�6!   .+�5a      �� $��
Номер��6$   
�������$��16(�5c   $   $��0 0 0 10q�5d   $   $��Center=�5e   $   �� 5f      $	��230��6"   $��30��5g   "   #��[  5h   "   ��5i   "   �� *LicenceNumber+5k      5m      5o      5q      �� 5s   
   $  
Horizontal=�6   $��Center=�5t      $��0 15 0 0q�5u      .+�5w      �� $��СОЗДАТЬ��6   $��16(�5x      
�������
���   �  2buttons#��[ 5{      ��5|      �� *
AddCommand+5}      5~      5      