   M S B A M L   `   `   `  ����>  :Zoo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Zoo.Views	Zoo.Views  5	   	       Zoo.Views.TicketsView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Zoo.Views     5	   	   b ^Syncfusion.SfChart.WPF, Version=20.2500.0.39, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.4500.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89i eSyncfusion.Shared.WPF.Classic, Version=19.4500.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89`	 \Syncfusion.Tools.Wpf, Version=19.4500.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89h
 dSyncfusion.Tools.Wpf.Classic, Version=19.4500.0.56, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89:
syncfusion!http://schemas.syncfusion.com/wpf    	 
 5
   	   .��5      �   � RowDefinitions  5   
   �� 5      $��60 �6   �� 5      $��60 �6   �� 5      �� 5      $��20 �6   .+�5   
   ��  �� DisplayMemberPath$
 Type��5       �� SelectedValuePath$
 Type��5      $��18(�5      $
��Left=�5      $��	165,0,0,0q�6(   $��1��6;   $��Center=�6H   $	��175��6c   $��30��6o   ��5      �� *TicketsTypes+ �� SelectedItem 5      ��  �� Path$ SType� �� SelectedValue 5      �� *Name+ �� Mode$ TwoWay=�5   o   �� 5   
   $��2��65   $��Купи��6B   $	��120��6Q   $��30��6]   $��18(�6i   $��712,215,28,45q�6w   ��6   �� *SaveTicketsToDb+6w   �� 5   
   $��0��5      $��	30,5,30,0q�6   $��Center=�6-   $��NoWrap=�6K   $��Билети��6a   $	��Top=�6o   $��36(�6�   $��1��6�   $	��170��6�    �� TextAlignment$ Center=�6�   $��Sitka Heading)�6�   ���	#FFFF8000���	#FF269C1C$��45��6  �� 5    
   $��2��6   $��Добави��6   $	��120��6/   $��30��6;   $��18(�6G   $��30,130,678,93q�6U   $	��Top=�6�   $
��Left=�6�   ��6l   �� *DisplayTicketsOnTable+6�   �� 5"   
   $��Тип на билета��6   $
��Left=�6(   $��32,0,0,0q�6C   $��1��6U   $��Center=�6b   $��16(�6}   ���	#FFD7DCDB6�   �� 5#   
   $��80��6   $	��210��6   $��Брой билети��6+   $��2��6@   $
��Left=�6N   $	��Top=�6i   $��	30,30,0,0q�6�   $��16(�6�   $
��Bold"�6�   
���   ����	#FFF56A6A.��5$      &   Syncfusion.Windows.Shared.UpDown  $��18(�6       NumberDecimalDigits$ 0��6.   	   MinValue$	 0Q�6F   $��Center=�6o   $��30��6�   
   NullValueText$
 Enter your weight:��6�      UseNullOption$
 True��6�   $	��Top=�6�   $	��176��6�      Culture$ en-US��6�    J� RenderTransformOrigin$ 0.536,1.607&�6     Value 6T   �� *SValue+6  5%      �� 5&   
   $	��159��6   $	��372��6    $��Резултати��6,   $��2��6?   $
��Left=�6M   $	��Top=�6h   $��
252,30,0,0q�6�   $��16(�6�   $
��Bold"�6�   
���   ���5'      
� 5(      .��5)      �  � Color$ Black��6#    � Offset$ 0.056Q�61   � 5*      $ White��6#   � 5+      $ 	#FFF56A6A��6#   $ 0.008Q�65   � 5,      $ 	#FFD6D6D6��6#   $ 0Q�65   5-      .��5/      �� $��16(�6>   $	��342��6L   $	��130��6X   ��6   �� *TicketsDisplay+ �� View 50      �� 51       �� AllowsColumnReorder$
 true��6    �� ColumnHeaderToolTip$ Тип��6:   .P�52      �� $��Тип на билета��53   %    �� Width$	 120��6<    �� DisplayMemberBinding 52   )   �� *Type+53   <   �� 54      $��Цена в лв.��6Q   $	 120��6e    6)   �� *Price+6e   �� 55      $��Брой��6R   $	 100��6`    6)   �� *Number+6`   59      5;      5<      �� 5=   
   $��80��6   $	��184��6   $#��Крайна цена в лв��6+   $��2��6E   $
��Left=�6S   $	��Top=�6n   $��648,109,0,0q�6�   $��16(�6�   $
��Bold"�6�   
���   ����	#FF0E0E0E���	#FFF1F0F0.��5>      �� $ Center=�64   $��22(�6K   $��Stretch=�6Y   $��	10,0,10,0q�6w   $
��Wrap=�6�   $��Center=�6�   $��34��6�   $	��150��6�   ��6   �� *
FinalPrice+6�   5?      5B      5C      