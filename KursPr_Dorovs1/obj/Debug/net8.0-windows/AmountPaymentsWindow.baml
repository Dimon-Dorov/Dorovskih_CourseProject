   M S B A M L   `   `   `  ����I  EKursPr_Dorovs1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:KursPr_DorovsKursPr_Dorovs  5   	   (    "KursPr_Dorovs.AmountPaymentsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:KursPr_Dorovs     5   	     � Title$]  WСписок інформації про грошовий внесок студента��5   	   $	��570��6@   $	��440��6M   .��5	      � .+�5
   
   �� -   5        $��Center=�5
      $	��Top=�6.   $��	20,5,20,5q�6F   $��0,37,0,0q�6Z   $	��400��6l   .��5      �� $:��4Змінити вартість проживання��6   $��18(�6;   $
��Wrap=�6I    �� TextAlignment$ Center=�6]   5      �� 5   
   -   5        $��Center=�5      $	��Top=�6.   $��	20,5,20,5q�6F   $��	0,426,0,0q�6Z   $	��400��6m   .��5      �� $0��*Додати грошовий внесок��6   $��18(�66   $
��Wrap=�6D   $ Center=�6X   5      �� 5   
   -   5        $��Center=�5      $	��Top=�6.   $��	20,5,20,5q�6F   $��0,78,0,0q�6Z   $	��400��6l   .��5      �� $A��;Повернутися на початковий екран��6   $��18(�6?   $
��Wrap=�6M   $ Center=�6a   5      �� 5   
   -   5         ��Name$ AmountPaymentItemList��5      $��16(�6]   $��0,119,0,192q�6k    �� View 5      �� 5      .P�5      �� $��ПІБ��6%    �� Width$	 210��62    �� DisplayMemberBinding 6>   �� *Student.StName+�� 5      $��Сума внеску��6%   $	 210��6:    6F   �� *	Payment+5      5      �� 5   
   $��ПІБ:��6   $��16(�6   $
��Left=�6-   $��
10,367,0,0q�6H   $	��Top=�6\   $��38��6t   �� 5   
   -   5         ��Name$ NameTextBox��5      $��16(�6�   $
��Left=�6�   $��
48,371,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��182��6�   $��50��6�   ��6'   �� *SelectedItem.Student.StName+ �� ElementName$ AmountPaymentItemList��	 �� Mode$	 OneWay=�6�   �� 5   
   $��Внесок:��6   $��16(�6"   $
��Left=�60   $��235,367,0,0q�6K   $	��Top=�6`   �� 5   
   -   5        $ PaymentTextBox��5      $��16(�6�   $
��Left=�6�   $��300,371,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��110��6�   ��6*   �� *SelectedItem.Payment+$ AmountPaymentItemList��$	 OneWay=�6�   �� 5   
   $
��Left=�6   $��9,11,0,0q�6/   $
��Wrap=�6A   $,��&Вартість проживання:��6U   $	��Top=�6q   $
��Bold"�6�   $��16(�6�   �� 5!   
   -   5        $��Center=�5!      $	��Top=�6.   $��	20,5,20,5q�6F   $��	0,467,0,0q�6Z   $	��400��6m   .��5"      �� $2��,Змінити грошовий внесок��6   $��18(�67   $
��Wrap=�6E   $ Center=�6Y   5#      �� 5$   
   -   5        $ CostTextBox��5$      $��16(�6'   $
��Left=�65   $��
210,10,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��112��6�   5%      5&      