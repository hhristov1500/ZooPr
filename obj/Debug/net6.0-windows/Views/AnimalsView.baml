   M S B A M L   `   `   `  ����>  :Zoo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Zoo.Views	Zoo.Views  5   	       Zoo.Views.AnimalsView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Zoo.Views     5   	   .��5	      �   � RowDefinitions  5
   
   �� 5      $��60 �6   6,   �� 5      $��60 �6   6*   �� 5      6   �� 5      $��20 �6   6*   .+�5   
   ��  �� DisplayMemberPath$
 Name��5       �� SelectedValuePath$
 Name��5      $��20(�5      $
��Left=�6    $��	35,10,0,0q�6;   $��1��6N   $	��Top=�6[   $	��230��6s   $��30��6   ��5      �� *
Categories+ �� SelectedItem 5      ��  �� Path$ 	SCategory� �� SelectedValue 5      �� *Name+ �� Mode$ TwoWay=�5      �� 5   
   -   5         ��Name$ button��5      $��1��6C   $��
Търси��6P   ���	#FFC8C8C8$	��120��6w   $��30��6�   $��18(�6�   $��280,10,460,20q�6�   ��6!   �� *SearchAnimals+6�   �� 5   
   $��0��6   $��0,5,0,0q�6!   $��Center=�62   $��NoWrap=�6P   $��Животни��6f   $	��Top=�6u   $��36(�6�   $��1��6�   $	��170��6�    �� TextAlignment$ Center=�6�   $��Sitka Heading)�6�   ���	#FFFF8000���	#FF269C1C$��45��6  �� 5   
   $	��219��6   $	��264��6    $��Резултати��6,   $��2��6?   $
��Left=�6M   $��Center=�6h   $��30,0,0,0q�6�   $��16(�6�   $
��Bold"�6�   
���   ����	#FFF56A6A.��5      �� ���	#FFDCD5D5
���   �$��Normal"�6�   $��16(�6�   $	��242��6�   $	��190��6�   ��6   �� *	Animals+ 67   �� *	SAnimal+	 �� View	 5      �� 5      
 �� AllowsColumnReorder$

 true��6    �� ColumnHeaderToolTip$ Searched Parts��6:   .P�5      �� $��Наименование��5   %    �� Width$	 120��6;    �� DisplayMemberBinding 5   )   �� *Name+5   ;   �� 5      $��Вид��6T   $	 120��6a    6)   �� *
Category+6a   5!      5#      5$      �� 5%   
   $	��218��6   $	��174��6    $��Описание��6,   $��2��6>   $
��Left=�6L   $��Center=�6g   $��	315,0,0,0q�6�   $��16(�6�   $
��Bold"�6�   
���   ����	#FFF9F4F4
���   �.��5&      �� -   5        $��tbtest��5&      $
��Wrap=�6K   $��Center=�6_   $	��180��6z   $��14(�6�   $
��Bold"�6�   $��5,0,5,0q�6�   ���	#FF312E2E$y�Visible=�6�   ��6&   �� *SAnimal.Description+ J� IsHitTestVisible 6�   ��  �� ElementName$ button��$ OneWay=� J� Effect 5'      3  -System.Windows.Media.Effects.DropShadowEffect  5(         
BlurRadius$ 10Q�6'      Color$ White��67      ShadowDepth$ 0Q�6E   5*      5+      �� 5,   
   $	��218��6   $	��302��6    $��Снимка��6,   $��2��6<   $
��Left=�6J   $��Center=�6e   $��	528,0,0,0q�6�   $��18(�6�   $
��Bold"�6�   
���   ����	#FFF1F0F0��5-      �� 5.       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5/      �  � Color$ 	#FF9E9A9A��6#    � Offset$ 1Q�65   � 50      $ Black��6#   $ 0.016Q�61   � 51      $ Black��6#   $ 0.831Q�61   52      .��54      �� -   5         ��Name$	 img��54      $��Stretch=�55      $	��173��6+   $��5,5,5,5q�68   $��Stretch=�6I   $	��250��6e    J� RenderTransformOrigin$ 0.506,-0.012&�6q   ��54   !   �� *SAnimal.Image+55   q   56      58      59      