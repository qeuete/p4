   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.AddEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  AddEditPage��5	      .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      .+�5   
   �� $��Фамилия��6   $��0��6#   $��Center=�60   $��Center=�6M   �� 5   
   $��Имя��6   $��1��6   $��Center=�6,   $��Center=�6I   �� 5   
   $��Отчество��6   $��2��6$   $��Center=�61   $��Center=�6N   �� 5   
   $��
Почта��6   $��3��6!   $��Center=�6.   $��Center=�6K   �� 5   
   $!��Номер телефона��6   $��4��6*   $��Center=�67   $��Center=�6T   �� 5   
   $��Дата рождения��6   $��5��6)   $��Center=�66   $��Center=�6S   �� 5   
    �� 	MaxLength$	 100��6+   $��1��6;   $��0��6L   $��50��6Y   ��6   �� *	Surname+6Y   �� 5   
   $	 100��6-   $��1��6=   $��1��6N   $��50��6[   ��6   �� *	Firstname+6[   �� 5    
   $	 100��6.   $��1��6>   $��2��6O   $��50��6\   ��6   �� *
Middlename+6\   �� 5!   
   $ 50��6)   $��1��68   $��3��6I   $��50��6V   ��6   �� *Email+6V   �� 5"   
   $ 11��6*   $��1��69   $��4��6J   $��50��6W   ��6   �� *Number+6W   �� 5#   
   $��1��6/   $��5��6@   $��50��6M   ��6   �� *DateofBirth+6M   �� 5$   
   -   5        $��BtnSave��5$   \   $��Сохранить��6   $��2��6%   $��6��6O   $	��300��6k   ���	#FF87D24B6w   5%      5&      