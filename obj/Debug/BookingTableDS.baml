   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.BookingTableDS   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  BookingTableDS��5	      .��5
      �  � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ BookingViewDS��5   /      AutoGenerateColumns .  $
��Left=�6F   $��4��6a   $	��400��6u      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Клиент��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *fio+  5      $ 
Номер��6%    64   �� *number+  5      $ Дата въезда��6%    6:   �� *	dtincheck+ �� StringFormat$ {0:dd.MM.yyyy}��  5      $ Дата выезда��6%    6:   �� *dtoutncheck+$ {0:dd.MM.yyyy}��5      �� 5   
   -   5        	 ��Name$	 	SearchTxt��5      $��0��6%   $��3��62   $��3��6B   $��20��6V   $	��Top=�6b   $	��200��6z   $��Right=�6�   $��
0,39,114,0q�6�   �� 5   
   -   5        $��6��5      $��0��66   $��
Поиск��6C   $	��100��6S   $��40��6_   $
��Left=�6k   $��0,10,0,0q�6�   $	��Top=�6�   �� 5    
   -   5        $��6��5       $��Очистка��66   $	��100��6H   $��40��6T   $
��Left=�6a   $��0,50,0,0q�6|   $	��Top=�6�   �� 5!   
   -   5        
 ��Name$
 FioCbx��5!       �� DisplayMemberPath$	 fio��6#   $��Right=�6c   $��0��6   $��40��6�   $��3��6�   $��4��6�   $	��Top=�6�   $	��200��6�   $��0,112,114,0q�6�    � 5"   
   -   5          �Name$ 	PageFrame��5"      $��1��6#   $��3��60     � NavigationUIVisibility$ Hidden=�6D   5#      5$      