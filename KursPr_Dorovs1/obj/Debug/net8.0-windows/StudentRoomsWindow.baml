   M S B A M L   `   `   `  ����I  EKursPr_Dorovs1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:KursPr_DorovsKursPr_Dorovs  5   	   &     KursPr_Dorovs.StudentRoomsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:KursPr_Dorovs     5   	     � Title$l  fСписок інформації про заселення та виселення студентів��5   	   $	��530��6H   $	��750��6U   .��5	      � .+�5
   
   �� -   5        $��Center=�5
      $	��Top=�6.   $��	20,5,20,5q�6F   $��0,10,0,0q�6Z   $	��400��6l   .��5      �� $I��CЗмінити кімнату проживання студента��6   $��18(�6C   $
��Wrap=�6Q    �� TextAlignment$ Center=�6e   5      �� 5   
   -   5        $��Center=�5      $	��Top=�6.   $��	20,5,20,5q�6F   $��0,51,0,0q�6Z   $	��400��6l   .��5      �� $A��;Повернутися на початковий екран��6   $��18(�6?   $
��Wrap=�6M   $ Center=�6a   5      �� 5   
   -   5        $
��Left=�5      $	��Top=�6,   $��	20,5,20,5q�6D   $��549,391,0,0q�6X   $	��161��6m   .��5      �� $��Змінити��6   $��18(�6'   $
��Wrap=�65   $ Center=�6I   5      �� 5   
   -   5        $
��Left=�5      $	��Top=�6,   $��	20,5,20,5q�6D   $��549,438,0,0q�6X   $	��161��6m   .��5      �� $��Видалити��6   $��18(�6(   $
��Wrap=�66   $ Center=�6J   5      �� 5   
   -   5         ��Name$ StudentRoomsItemList��5      $��16(�6\   $��
0,92,0,128q�6j    �� View 5      �� 5      .P�5      �� $��Номер кімнати��6%    �� Width$	 130��6<    �� DisplayMemberBinding 6H   �� *Room.RoomId+�� 5      $��ПІБ��6%   $	 250��62    6>   �� *Student.StName+�� 5      $!��Дата заселення��6%   $	 170��6=    6I   �� *DateIn+�� 5      $!��Дата виселення��6%   $	 170��6=    6I   �� *	DateOut+5      5      �� 5    
   $ ��Номер кімнати:��6   $��16(�6)   $
��Left=�67   $��264,393,0,0q�6R   $	��Top=�6g   �� 5!   
   -   5         ��Name$ DateOutTextBox��5!      $��16(�6   $
��Left=�6�   $��139,397,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6*   �� *SelectedItem.DateOut+ �� ElementName$ StudentRoomsItemList��	 �� Mode$	 OneWay=�6�   �� 5"   
   $"��Дата заселення:��6   $��16(�6*   $
��Left=�68   $��
12,440,0,0q�6S   $	��Top=�6g   �� 5#   
   -   5        $ DateInTextBox��5#      $��16(�6}   $
��Left=�6�   $��138,444,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6)   �� *SelectedItem.DateIn+$ StudentRoomsItemList��$	 OneWay=�6�   �� 5$   
   $"��Дата виселення:��6   $��16(�6*   $
��Left=�68   $��
10,393,0,0q�6S   $	��Top=�6g   �� 5%   
   -   5        $ RoomNumberTextBox��5%      $��16(�6�   $
��Left=�6�   $��393,397,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6-   �� *SelectedItem.RoomId+$ StudentRoomsItemList��$	 OneWay=�6�   5&      5'      