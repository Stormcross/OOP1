   M S B A M L   `   `   `  ����I  EVjezbaOglasnik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VjezbaOglasnikVjezbaOglasnik  5   	       VjezbaOglasnik.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:VjezbaOglasnik     5   	     � Title$  Oglasnik��5   	   $	��600��6   $	��800��6'   .��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��2* �6   �� 5      $��5* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��2��6   $*��$Predaja oglasa za prodaju automobila��6%   $��Center=�6T   $��20(�6q   6�   �� 5    
   $��Tip vozila:��6   $��1��6&   65   �� 5!   
   $��Proizvodac:��6   $��2��6&   65   �� 5"   
   $��Godina proizvodnje:��6   $��3��6.   6=   �� 5#   
   $��Novo vozilo��6   $��4��6&   65   �� 5$   
   $��Prvi vlasnik:��6   $��5��6(   67   �� 5%   
   $��Dodatna oprema:��6   $��6��6*   69   �� 5)   
   -   5        $��
tipTextBox��5)      $��1��6$   $��1��64   $��3q�6A   6N   �� 5,   
   -   5        $��proizvodacListBox��5,      $��2��6+   $��1��68   $��3q�6H   6U   �� 5-   
   -   5        $��opremaListBox��5-      $��6��6'   $��1��64   $��3q�6D    �� SelectionMode$ Extended=�6O   6j   �� 50   
   -   5        $��godinaProizvodnjeComboBox��50      $��3��64   $��Center=�6A   $
��Left=�6c   $��1��6�   $��3q�6�   6�   �� 53   
   $��1��6   $��4��6%    �� Orientation$ 
Horizontal=�62   $��Center=�6K   .+�54      	� -   5        $��novoRadioButton��54   A    	� 	GroupName$  novoVoziloRadioButtonGroup��6   $
��Novo��6X   $��3q�6g   	� 55      -   5        $��koristenoRadioButton��55   A   $  novoVoziloRadioButtonGroup��6   $��	Koristeno��6]   $��3q�6q   56      �� 58   
   $ 
Horizontal=�6   $��1��6.   $��7��6>   .+�59      �� -   5        $��posaljiButton��59      $��Posalji��6*   $
��Left=�6<   $��20,10,20,10q�5:      $��5q�6+   $	��100��6R   6`   �� 5;      -   5        $��izlazButton��5;      $��Izlaz��6(   $
��Left=�68   $��20,10,20,10q�5<      $��5q�6+   $	��100��6P   6^   5=      �� 5@   
   -	   5        $��prviVlasnikCheckBox��5@      $��1��6.   $��5��6>   $��3q�6K   $��Center=�6V   6s   &   System.Windows.Controls.DataGrid  5D   
   -
   5        $��listaDataGrid��5D         
IsReadOnly . $��8��6:   $��2��6G      AutoGenerateColumns . 5F      5H      5J      