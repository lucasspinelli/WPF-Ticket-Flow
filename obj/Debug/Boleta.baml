   M S B A M L   `   `   `  ����B  >Boletas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BoletasBoletas  5   	       Boletas.Boleta   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Boletas     5   	     � Title$  Boleta��5   	   $��624.515��6   $��798.753��6)   .��5	      � $��0,0,2,2q�6    � RowDefinitions 5
   
   �� 5      .+�5   
   a� $
��Left=�6   $	��592��62   $	��Top=�6?   $��29��6W   ���	#FF2BC57F6b   �� 5   
   $��Visible=�5      $��Hidden=�5      $��44,52,28,299q�6<    J� RenderTransformOrigin$ 0.5,0.5&�6R   .��5      &   System.Windows.Controls.DataGrid  -   5           AutoGenerateColumns .     
IsReadOnly . $	��186��5      $	��701��5      $
��Left=�6   $	��Top=�5      ��5      �� *PreBoletasAprovadas+ �� SelectedItem 5      �� *SelectedPreBoleta+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Grupo de Carteira��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *grupoCarteira+  5      $ Carteira��6)    6;   �� *
carteira+  5      $ Ação��6)    67   �� *acao+  5      $ Clase da Operação��6)    6D   �� *
classeOp+  5       $ PU��6)    65   �� *pu+  5!      $ 
Quantidade��6)    6=   �� *
quantidade+  5"      $ Valor��6)    68   �� *valor+  5#      $ Conta Associada��6)    6B   �� *contaAssociada+  5$      $ 	Corretora��6)    6<   �� *	corretora+  5%      $ Status��6)    69   �� *status+5'      5(      �� 5)   
   $
��Left=�6   $��41��60   $	��Top=�6<   $	��311��6T   $��
44,325,0,0q�6`   	 �� Orientation$	 
Horizontal=�6t   .+�5*      �� $��2,2,2,10q�6   $��2q�5+      
���   �$��Adicionar Nova��5-      $	��105��5.      $��Verdana)�5/      ��50      �� ��51      �� *CommandAdicionar+��52      �� 53      
 �� EndPoint$
 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��54      �  � Color$ 	#FFD3D4D3��6'    � Offset$ 0Q�69   � 55      $ 	LimeGreen��6'   $ 1Q�69   56      58      �� 59      $��2,2,2,10q�6   $��2q�5:      
���   �$��Editar��5<      $��62��5=      $��Verdana)�5>      ��5?      �� ��5@      �� *CommandEditar+��5A      �� 5B      $
 0.5,1&�6*   $ 0.5,0&�6;   .��5C      � $ 	#FFD1D0CF��6'   $ 0Q�69   � 5D      $ Orange��6'   $ 1Q�66   5E      5G      �� 5H      $��2,2,2,10q�6   $��2q�5I      
���   �$��Deletar��5K      $��69��5L      $��Verdana)�5M      ��5N      �� ��5O      �� *CommandDeletar+��5P      �� 5Q      $
 0.5,1&�6*   $ 0.5,0&�6;   .��5R      � $ 	#FFBDBCBC��6'   $ 0Q�69   � 5S      $ Tomato��6'   $ 1Q�66   5T      5V      5W      �� 5X   
   $��Pré-Boletas Aprovadas��6   $
��Left=�60   $��
44,0,0,545q�6K   $��Bottom=�6_   $	��163��6z   $
��Bold"�6�   $��14(�6�     5Y   
   -   5         .   . $	��186��5[      $	��682��5\      $
��Left=�6   $	��Top=�5]      $��
44,371,0,0q�5`   5   ��5_      �� *	Boletas+ 5`      �� *SelectedBoleta+ 5a        5b      $ Grupo de Carteira��6%    6@   �� *grupoCarteira+  5c      $ Carteira��6%    67   �� *
carteira+  5d      $ Ação��6%    63   �� *acao+  5e      $ Clase da Operação��6%    6@   �� *
classeOp+  5f      $ PU��6%    61   �� *pu+  5g      $ 
Quantidade��6%    69   �� *
quantidade+  5h      $ Valor��6%    64   �� *valor+  5i      $ Conta Associada��6%    6>   �� *contaAssociada+  5j      $ 	Corretora��6%    68   �� *	corretora+5l      �� 5m   
   $��Boletas��6   $
��Left=�6"   $��
44,0,0,272q�6=   $��Bottom=�6Q   $	��163��6l   $
��Bold"�6x   $��14(�6�   5p      5q      