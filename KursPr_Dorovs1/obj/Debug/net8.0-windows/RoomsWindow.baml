   M S B A M L   `   `   `  ����I  EKursPr_Dorovs1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:KursPr_DorovsKursPr_Dorovs  5   	       KursPr_Dorovs.RoomsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:KursPr_Dorovs     5   	     � Title$=  7Список інформації про кімнати��5   	   $	��495��6/   $	��420��6<   .��5	      � .+�5
   
   �� -   5        $��Center=�5
      $	��Top=�6.   $��	20,5,20,5q�6F   $��0,10,0,0q�6Z   $	��380��6l   .��5      �� $A��;Повернутися на початковий екран��6   $��18(�6?   $
��Wrap=�6M    �� TextAlignment$ Center=�6a   5      �� 5   
   -   5         ��Name$ RoomsItemList��5      $��16(�6U   $��
0,51,0,222q�6c    �� View 5      �� 5      .P�5      �� $��Номер кімнати��6%    �� Width$	 200��6<    �� DisplayMemberBinding 6H   �� *RoomId+�� 5      $#��Кількість ліжок��6%   $	 200��6>    6J   �� *
SleepCount+5      5      �� 5   
   $ ��Номер кімнати:��6   $��16(�6)   $
��Left=�67   $��
11,257,0,0q�6R   $	��Top=�6f   �� 5   
   -   5         ��Name$ RoomNumberTextBox��5      $��16(�6z   $
��Left=�6�   $��168,261,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6-   �� *SelectedItem.RoomId+ �� ElementName$ RoomsItemList��	 �� Mode$	 OneWay=�6�   �� 5   
   $$��Кількість ліжок:��6   $��16(�6+   $
��Left=�69   $��
11,288,0,0q�6T   $	��Top=�6h   �� 5   
   -   5        $ BedCountTextBox��5      $��16(�6|   $
��Left=�6�   $��168,292,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6+   �� *SelectedItem.SleepCount+$ RoomsItemList��$	 OneWay=�6�   �� 5   
   -   5        $��Center=�5      $	��Top=�6.   $��	20,5,20,5q�6F   $��	0,333,0,0q�6Z   $	��380��6m   .��5      �� $%��Створити кімнату��6   $��18(�60   $
��Wrap=�6>   $ Center=�6R   5      �� 5   
   -   5        $��Center=�5      $	��Top=�6.   $��	20,5,20,5q�6F   $��	0,415,0,0q�6Z   $	��380��6m   .��5      �� $#��Змінити кімнату��6   $��18(�6/   $
��Wrap=�6=   $ Center=�6Q   5      �� 5   
   -   5        $��Center=�5      $	��Top=�6.   $��	20,5,20,5q�6F   $��	0,374,0,0q�6Z   $	��380��6m   .��5       �� $%��Видалити кімнату��6   $��18(�60   $
��Wrap=�6>   $ Center=�6R   5!      5"      5#      