   M S B A M L   `   `   `  ���� C  ?uniCovid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:uniCoviduniCovid  7 clr-namespace:uniCovid.resourcesuniCovid.resources      uniCovid.winCRUD   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:uniCovid     7
properties clr-namespace:uniCovid.resources     -     � Title$  winCRUD��$	��500��$
��1000�� � 	Resources    prUniDBViewSource��%   &	        �� .��� 
���   � � DataContext# [  $��0,10,3.333,-0.333q�.+��� -    ��Name$
 Logo��$	��100��$	��Top=�$	��100��$��/resourse/logo.png��$��Center=�$��451,5,435,0q��� -    ��Name$ btnSalir��$��Right=�$��Bottom=�$	��100��$��Futura)����#3CAEA3$��20(�
����������#3CAEA3$��40��$��	0,0,10,10q�����  �� Path$ bthSalir�  	Resources �� Source# [ �� -   $ btnNuevo��$
��Left=�$��
913,10,0,0q�$	��Top=�$��67��$��58��
���   �.���� $��45��$	��Top=�$��48��$��/resourse/add.png��$��Right=�&   System.Windows.Controls.DataGrid  -     Name$ gridListado��$	��300��   AutoGenerateColumns .  	   EnableRowVirtualization	 . $��23,111,19,50q�
   RowDetailsVisibilityMode$
 VisibleWhenSelected=�$��20(�$��Futura)�   
IsReadOnly .    AlternatingRowBackground
 ��� �
���   �
���   �����    Columns 0  *System.Windows.Controls.DataGridTextColumn  -   provinciaColumn��,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	Provincia+   Header �� $ headerProvincia�# [   -   "tests_positivos_alumnadoColumn��$
 Auto  �� *Tests_positivos_alumnado+ �� $ headerTestAlumn�# [   -   %!tests_positivos_profesoradoColumn��$
 auto  �� *Tests_positivos_profesorado+ �� $ headerTestProf�# [ 4  .System.Windows.Controls.DataGridTemplateColumn  -	   fechaColumn��$
 auto  �� $ headerFecha�# [    CellTemplate �� .R���  �� Orientation$ 
Horizontal=�.+�(  "System.Windows.Controls.DatePicker     SelectedDate �� *Fecha+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . �� $ 	btnDetail��-
   
�������$��Verdana)�$
��Bold"�$��0,0,5,0q�.���� .+��� $��resourse/information.png��$��20��$��20���� $ btnEdit��-   
�������$��Verdana)�$
��Bold"�$��0,0,5,0q�.���� .+��� $��resourse/edit.png��$��20��$��20���� $ 	btnDelete��-   
�������$��Verdana)�$
��Bold"�$��0,0,5,0q�.���� .+��� $��resourse/delete.png��$��20��$��20��� -    �Name$ gridCajaEditar��$
��1000��$	��400��
���   �$��8,480,-20,-410q�.+��� -    ��Name$ lblTituloEditar��$
��Left=�$��	29,10,0,0q�$��Futura)�
�������$	��Top=�$��20(�$
��Bold"�$
��auto��$��48������ $ lblTituloEditar�# [ �� -   $ btnEditProd��$
��Left=�$��
766,18,0,0q�$	��Top=�$��Futura)�$��20(����#3CAEA3
�������$��40��$	��102������ $ 	btnModify�# [ �� -   $ btnVolverEdit��$��Right=�$��
0,0,158,63q�$��Bottom=�$��Futura)�$��20(����#3CAEA3
�������$��40��$��76������ $ btnBack�# [ � -   $ 
gridEditar��$
��Left=�$��193,127,0,0q�$	��Top=� � ColumnDefinitions �� $
��Auto � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $
��auto��$��0��$
��Left=�$��-171,-47,0,135.667q�$��Center=�$��Futura)�$��15(�
�������$��1������ $ lblProvincia�# [ ��Z� �� -    ��Name$ provinciaTextBoxEdit��$��0��$
��Left=�$��23��$��152,-42,-144,135.667q�$��0��$��Center=�$	��164������ *	Provincia+$ TwoWay=� .  . �� $
��auto��$��0��$
��Left=�$��-171,17,0,71.667q�$��Center=�$��Futura)�$��15(�
����������� $ 	lblTestAl�# [ ��Z� �� -   $) #tests_positivos_alumnadoTextBoxEdit��$��0��$
��Left=�$��24��$��204,21,-196,71.667q�$��Center=�$	��164������ *Tests_positivos_alumnado+$ TwoWay=� .  . �� $
��auto��$��0��$
��Left=�$��-171,75,0,8q�$��Center=�$��Futura)�$��15(�
����������� $ 	lblTestPr�# [ ��Z� �� -   $, &tests_positivos_profesoradoTextBoxEdit��$��0��$
��Left=�$��23��$��204,78,-196,15.667q�$��Center=�$	��164������ *Tests_positivos_profesorado+$ TwoWay=� .  . �� $
��auto��$��0��$
��Left=�$��-171,15.333,0,-9.667q�$��Center=�$��Futura)�$��15(�
�������$��3������ $ lblDate�# [ ��Z�   -     Name$ fechaDatePicker2��$��0��$
��Left=�$��152,15.333,-126,-7q�$��3��$��Center=� �� *Fecha+$ TwoWay=� .  . � -   $ gridCajaDetalle��$	��400��$
��1000��$��1060,5,-1065,56q�
���   �.+��� -   $ lblTituloDetalle��$
��auto��$��Futura)�
�������$
��Left=�$��	26,25,0,0q�$	��Top=�$��20(�$
��Bold"�$��41������ $ lblTituloDetalle�# [ �� -   $��Right=�$��Bottom=�$��70��$��Futura)�$��20(����#3CAEA3
�������$��40��$��
0,0,120,33q����� $ btnBack�# [ � -   $ gridDetalle��$
��Left=�$��128,115,0,0q�$	��Top=� �� $
��Auto �$��128.667�� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $
��auto��$��0��$
��Left=�$��-110,-34,0,96.333q�$��Center=�$��Futura)�$��15(�
�������$��1������ $ lblProvincia�# [ ��Z� �� -   $ provinciaTextBox��$��0��$
��Left=�$��24��$��139,-12,-183.667,114q�$��0��$��Center=�$	��174������ *	Provincia+$ TwoWay=� .  . �� $
��auto��$��0��$
��Left=�$��-110,45,0,61q�$��Center=�$��Futura)�$��15(�
����������� $ 	lblTestAl�# [ ��Z� �� -   $% tests_positivos_alumnadoTextBox��$��0��$
��Left=�$��24��$��206,45,-250.667,65q�$��Center=�$	��174������ *Tests_positivos_alumnado+$ TwoWay=� .  . �� $
��auto��$��0��$
��Left=�$��-110,86,0,20q�$��Center=�$��Futura)�$��15(�
������� J� RenderTransformOrigin$ 0.639,-0.018&����� $ 	lblTestPr�# [ ��Z� �� -   $( "tests_positivos_profesoradoTextBox��$��0��$
��Left=�$��24��$��206,90,-249.667,20q�$��Center=�$	��173������ *Tests_positivos_profesorado+$ TwoWay=� .  . �� $
��auto��$��0��$
��Left=�$��-110,14.556,0,-8.556q�$��Center=�$��Futura)�$��15(�
�������$��3������ $ lblDate�# [ ��Z�   -   $ fechaDatePicker��$��0��$
��Left=�$!��129,24.556,-158.667,-16.556q�$��3��$��Center=�$��26��$	��159�� �� *Fecha+$ TwoWay=� .  . � -   $ gridCajaNuevo��$
��1000��$	��400��$��10,-473,0,532q�
���   �.+��� -   $ lblTituloNuevo��$
��Left=�$��	10,10,0,0q�$	��Top=�$��20(�$
��Bold"�$��Futura)�
�������$��40��$
��auto������ $ lblTituloNuevo�# [ z�V� .~��� �� ��  �� Angle$ -0.134Q�T� �� -    $ btnVolverNuevo��$
��auto��$��802,341,113,0q�$	��Top=�$��Futura)�$��20(����#3CAEA3
�������$��40������ $ btnBack�# [ �� -!   $ btnAddNuevo��$
��auto��$
��Left=�$��
802,21,0,0q�$	��Top=�$��Futura)�$��20(����#3CAEA3
�������$��40������ $ btnAdd�# [ � -"   $ grid1��$
��Left=�$��
191,98,0,0q�$	��Top=� �� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$
��auto��$
��Left=�$��-161,-19,0,53.333q�$��Center=�$��Futura)�$��15(�
�������$��1������ $ lblProvincia�# [ ��Z� �� -#   $ ProvinciaTextBoxNuevo��$��0��$
��Left=�$��22��$��113,-13,-131,53q�$��Center=�$	��190���� $
��auto��$��0��$
��Left=�$��-161,34,0,0.333q�$��Center=�$��Futura)�$��15(�
����������� $ 	lblTestAl�# [ ��Z� �� -$   $* $Tests_positivos_alumnadoTextBoxNuevo��$
��Left=�$��23��$��172,29,-190,10q�$��Center=�$	��190���� $
��auto��$��0��$
��Left=�$��-164,29.667,0,-26q�$��Center=�$��Futura)�$��15(�
�������$��3������ $ 	lblTestPr�# [ ��Z� �� -%   $- 'Tests_positivos_profesoradoTextBoxNuevo��$��3��$��23��$��172,31,-190,-20.667q�$��Center=��� $
��auto��$��0��$
��Left=�$��-161,99.667,0,-95.333q�$��Center=�$��Futura)�$��15(�
�������$��3������ $ lblDate�# [ ��Z�   -&   $ fechaDatePicker1��$��3��$��0��$
��Left=�$��113,100,-87,-92.333q�$��Center=�