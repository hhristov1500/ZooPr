   M S B A M L   `   `   `  ����>  :Zoo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Zoo.Views	Zoo.Views  5   	       Zoo.Views.EventsView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Zoo.Views     5   	   .��5	      �   � RowDefinitions  5
   
   �� 5      $��60 �6   6*   �� 5      $��60 �6   6*   �� 5      6   �� 5      $��20 �6   6*   .+�5   
   ��  �� DisplayMemberPath$
 Type��5       �� SelectedValuePath$
 Type��5      $��20(�5   B   $
��Left=�6P   $��	200,0,0,0q�6k   $��1��6~   $��Center=�6�   $	��150��6�   $��35��6�   ��5      �� *
EventTypes+ �� SelectedItem 5      ��  �� Path$ SEventsType� �� SelectedValue 5      �� *Name+ �� Mode$ TwoWay=�6�   �� 5   
   $��1��62   $��
Търси��6?   $	��120��6O   $��30��6[   $��20(�6g   $��350,15,370,15q�6u   ���	#FFC7C7C7��6   �� *SearchEvents+6�   �� 5   
   $��0��6   $��	30,5,30,0q�6!   $��Center=�64   $��NoWrap=�6R   $��Събития��6h   $	��Top=�6w   $��36(�6�   $��1��6�   $	��170��6�    �� TextAlignment$ Center=�6�   $��Sitka Heading)�6�   ���	#FFFF8000$��45��6  ���	#FF269C1C6  (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�65   $��35,0,0,0q�6P   $��1��6b   $��Center=�6o   $��35��6�   $	��150��6�   $��20(�6�      SelectedDate 6   �� *SDate+6�   �� 5   
   $��Резултати��6   $��2��6&   $��	35,0,0,18q�63   $
��Left=�6F   $��16(�6a   $��Bottom=�6o   $��2��6�   $	��494��6�   $
��Bold"�6�   ���	#FFF56A6A.��5      �� $��20(�6W   $	��219��6e   $��5,5,5,5q�6r   $��Normal"�6�   ��6   �� *Events+ 66   �� *SEvent+	 �� View	 5      �� 5      
 �� AllowsColumnReorder$

 true��6    �� ColumnHeaderToolTip$ Събития��6:   .P�5      �� $��Събитие��5   %    �� Width$	 180��67    �� DisplayMemberBinding 5   )   �� *Name+5   7   �� 5      $��Вид��6P   $	 145��6]    6)   �� *Type+6]   �� 5       $��Дата��6O   $	 140��6]    6)   �� *Date+6]   5"      5$      5%      �� 5&   
   $	��254��6   $	��223��6    $��Описание��6,   $��2��6>   $��Right=�6L   $��Bottom=�6h   $��0,0,40,0q�6�   $��18(�6�   $
��Bold"�6�   
���   ����	#FFF1F0F0��5'      �� 5(       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5)      �  � Color$ 	#FF9E9A9A��6#    � Offset$ 1Q�65   � 5*      $ Black��6#   $ 0.016Q�61   � 5+      $ Black��6#   $ 0.831Q�61   5,      .��5.      �� $��20(�6<   $��Stretch=�6J   $��5,5,5,5q�6h   $
��Wrap=�6y   $��Stretch=�6�   ��6   �� *SEvent.Description+ J� Effect 5/      3  -System.Windows.Media.Effects.DropShadowEffect  50         
BlurRadius$ 50Q�6'      Color$ White��67      ShadowDepth$ 0Q�6E   52      53      55      56      