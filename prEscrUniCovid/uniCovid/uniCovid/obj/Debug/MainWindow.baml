   M S B A M L   `   `   `  ����C  ?uniCovid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:uniCoviduniCovid  5   	   7 clr-namespace:uniCovid.resourcesuniCovid.resources  5   	       uniCovid.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +uniCovidclr-namespace:uniCovid     5   	   7
properties clr-namespace:uniCovid.resources     5   	     � Title$  
MainWindow��5
   	   $	��500��6   $	��800��6)    � 	Resources 5         LanguagesDataTemplate �� Path��%Q   &	        �� 5   
   .R�5      �� ��6   �� $ 
NativeName�5      5      .��5      � 
���   �$��0,0,0.333,-4.333q�6    � ColumnDefinitions 5   
   �� 5      $
��142* �6   �� 5      $	��29* �6   �� 5      $
��623* �6   .+�5   
   �� $	��143��6   $	��Top=�6   $	��161��67   $��/resourse/logo.png��6C   $��Center=�6_   $��166.333,48,295.333,0q�6|   $��2��6�   �� 5#   
   -   5         ��Name$ btnListado1��5#   %  $��0.333,345,480.333,80q�6�   $��Futura New Roman)�6�   $��20(�6�   ���#3CAEA3
����������#3CAEA3$��2��6T  $��50��6d   � ToolTip 6   �� $ ttLista�  	Resources �� Source# [ ��6U   �� $ btnLista�# [ 6d  �� 5$   
   -   5        $ buttonSalir��5$     $��Right=�6V   $��Bottom=�6s   $��70��6�   $��Futura)�6�   $��20(�6�   ���#3CAEA3
����������#3CAEA3$��40��6�   $��0,0,10.334,10q�62  $��2��6I  ��6   �� $ bthSalir�# [ 6I  �� 5'   
   -   5        $ 
buttonCRUD��5'   A  $��50��6   $��306.333,333,96.333,67q�6   $	��220��6=   $��Futura)�6�   $��20(�6�   ���#3CAEA3
����������#3CAEA3$��2��61   6I   �� $ ttCrear�# [ ��6�   �� $ btnCrud�# [ 6U  �� 5(   
   -   5         ��Name$ cbLanguages��5(   8   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6   $��40��6M   #��[  6�   $��14(�6�   $��Stretch=�6  $
��Auto��6#  $��10.333,24,456.333,421q�60  $��2��6O  ��6Y   �� $ SupportedCultures�	 �� Mode$	 OneWay=�  CultureResourcesDS# [ 6O  �� 5)   
   $
��Left=�6X   $��Futura)�6t   $��15(�6�   $��	22,24,0,0q�6�   $	��Top=�6�   $	��173��6�   
�������$��30��6�   $��3��6�   ��6   �� $ labelChange�# [ 6�   A� 5*   
   $��2��6   $��535.333,10,10.333,388q�6"   ��5+      �� 5,      
 j� 
AlignmentX$
 Center=�6e    j� 
AlignmentY$ Center=�6y    �� ImageSource 6   �� $ imgFlag�# [ 6y   5.      �� 5/   
   
�������$��Center=�6$   $��Futura)�6A   $��Italic$�6U   $��20(�6h   $��Center=�6�   $��13.333,196,146.333,0q�6�   $	��Top=�6�   $
��auto��6  $
��auto��6#  $��2��60  ��6v   �� $ lblInf�# [ 60  �� 50   
   
�������$��Center=�6$   $��Futura)�6A   $��10q�6U   $��Italic$�6b   $��17(�6u   $��Center=�6�   $��0,235,75.333,0q�6�   $	��Top=�6�   $
��auto��6�   $	��600��6�   $��2��6�   $��1��6  .��51      �� $��WrapWithOverflow=�6Z   $��Center=�6z   ��6   �� $ lblAbout�# [ 6z   52      55      56      