   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.RoomsWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  Номера��5	      .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      $��30 �6   �� 5      $��60 �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	RoomsView��5   /      AutoGenerateColumns .  $
��Left=�6B   $��4��6]   $	��400��6q      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Тип��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *
TypeRoom+  5      $ Цена��6%    63   �� *	PriceRoom+  5      $ Доступность��6%    6:   �� *AvailabilityRoom+5      �� 5   
   -   5         ��Name$ TypeTbx��5      $��1��6#   $��0��60   $	��300��6@   �� 5    
   -   5        $ PriceTbx��5       $��1��6$   $	��150��61   $��1��6=   �� 5!   
   -   5        	 ��Name$	 AvailabilityCbx��5!      $��1��6,   $	��250��69   $��2��6E   �� 5"   
   -   5        $��BtnAdd��5"   8   $��Добавить��6   $��2��6F   $
��Left=�6S   $	��250��6n   ���	#FF87D24B$��2��6�   �� 5#   
   -   5        $��BtnEdit��5#   >   $ ��Редактировать��6   $��2��6M   $��Center=�6Z   $	��250��6w   ���	#FF87D24B$��6��6�   �� 5$   
   -   5        $��	BtnDelete��5$   :   $��Удалить��6   $��2��6L   $��Right=�6Y   $	��250��6u   ���	#FF87D24B$��7��6�   �� 5%   
   -   5        $ 	SearchTxt��5%      $��0��6%   $��3��62   $��3��6B   $��20��6V   $	��Top=�6b   $	��200��6z   $��Right=�6�   $��
0,39,114,0q�6�   �� 5&   
   -	   5        $��6��5&      $��0��66   $��
Поиск��6C   $	��100��6S   $��40��6_   $
��Left=�6k   $��0,10,0,0q�6�   $	��Top=�6�   �� 5'   
   -
   5        $��6��5'      $��Очистка��66   $	��100��6H   $��40��6T   $
��Left=�6a   $��0,50,0,0q�6|   $	��Top=�6�   �� 5(   
   -   5        $	 RoomsCbx��5(      $��Right=�6%   $��0��6A   $��40��6N   $��3��6Z   $��3��6j   $	��Top=�6~   $	��200��6�   $��0,112,114,0q�6�   
 �� DisplayMemberPath$
 TypeRoom��6�   6�    � 5)   
   -   5          �Name$ 	PageFrame��5)      $��1��6#   $��3��60     � NavigationUIVisibility$ Hidden=�6D   5*      5+      