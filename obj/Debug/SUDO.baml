   M S B A M L   `   `   `  ����B  >Boletas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BoletasBoletas  5   	       Boletas.SUDO   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Boletas     5   	     � Title$  Insira um titulo��5   	   $��621.5��6"   $
��1502��61   .��5	      �  J� RenderTransformOrigin$ 0.278,0.744&�6   $	��767��6/   $	��Top=�6<   $��
0,0,0,-176q�6T    � RowDefinitions 5
   
   �� 5      .+�5   
   a� $
��Left=�6   $	��594��62   $	��Top=�6?   $��29��6W   ���	#FF2BC57F6b   �� 5   
   $��Visible=�5      $��Hidden=�5      $��44,93,758,514q�6<   .��5      &   System.Windows.Controls.DataGrid  -   5           AutoGenerateColumns .     
IsReadOnly . $	��126��5      $	��682��5      $
��Left=�6   $	��Top=�5      ��5      �� *
PreBoletas+ �� SelectedItem 5      �� *SelectedPreBoleta+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Grupo de Carteira��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *grupoCarteira+  5      $ Carteira��6)    6;   �� *
carteira+  5      $ Ação��6)    67   �� *acao+  5      $ Clase da Operação��6)    6D   �� *
classeOp+  5      $ PU��6)    65   �� *pu+  5      $ 
Quantidade��6)    6=   �� *
quantidade+  5       $ Valor��6)    68   �� *valor+  5!      $ Conta Associada��6)    6B   �� *contaAssociada+  5"      $ 	Corretora��6)    6<   �� *	corretora+5$      5%      �� 5&   
   $��Visible=�5'      $��Hidden=�5(      $��44,289,758,293q�6<   .��5)        -   5         .   . $	��146��5+      $	��682��5,      $
��Left=�6   $	��Top=�5-      ��5/      �� *PreBoletasAprovadas+ 50      �� *SelectedPreBoleta+ 51        52      $ Grupo de Carteira��6)    6D   �� *grupoCarteira+  53      $ Carteira��6)    6;   �� *
carteira+  54      $ Ação��6)    67   �� *acao+  55      $ Clase da Operação��6)    6D   �� *
classeOp+  56      $ PU��6)    65   �� *pu+  57      $ 
Quantidade��6)    6=   �� *
quantidade+  58      $ Valor��6)    68   �� *valor+  59      $ Conta Associada��6)    6B   �� *contaAssociada+  5:      $ 	Corretora��6)    6<   �� *	corretora+  5;      $ Status��6)    69   �� *status+5=      5>      �� 5?   
   $
��Left=�6   $��41��60   $	��Top=�6<   $	��311��6T   $��	44,47,0,0q�6`   	 �� Orientation$	 
Horizontal=�6s   .+�5@      �� $��2,2,2,10q�6   $��2q�5A      
���   �$��Adicionar Nova��5C      $	��105��5D      $��Verdana)�5E      ��5F      �� ��5G      �� *CommandAdicionar+��5H      �� 5I      
 �� EndPoint$
 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5J      �  � Color$ 	#FFD3D4D3��6'    � Offset$ 0Q�69   � 5K      $ 	LimeGreen��6'   $ 1Q�69   5L      5N      �� 5O      $��2,2,2,10q�6   $��2q�5P      
���   �$��Editar��5R      $��62��5S      $��Verdana)�5T      ��5U      �� ��5V      �� *CommandEditar+��5W      �� 5X      $
 0.5,1&�6*   $ 0.5,0&�6;   .��5Y      � $ 	#FFD1D0CF��6'   $ 0Q�69   � 5Z      $ Orange��6'   $ 1Q�66   5[      5]      �� 5^      $��2,2,2,10q�6   $��2q�5_      
���   �$��Deletar��5a      $��69��5b      $��Verdana)�5c      ��5d      �� ��5e      �� *CommandDeletar+��5f      �� 5g      $
 0.5,1&�6*   $ 0.5,0&�6;   .��5h      � $ 	#FFBDBCBC��6'   $ 0Q�69   � 5i      $ Tomato��6'   $ 1Q�66   5j      5l      5m      �� 5n   
   $��Pré-Boletas��6   $
��Left=�6&   $��
44,0,0,727q�6A   $��Bottom=�6U   $��88��6p   $
��Bold"�6{   $��14(�6�   �� 5o   
   $��Pré-Boletas��6   $
��Left=�6&   $��
44,0,0,727q�6A   $��Bottom=�6U   $��88��6p   $
��Bold"�6{   $��14(�6�   �� 5p   
   $��Pré-Boletas Aprovadas��6   $
��Left=�60   $��
44,0,0,485q�6K   $��Bottom=�6_   $	��163��6z   $
��Bold"�6�   $��14(�6�   �� 5q   
   $��Visible=�5r      $��Hidden=�5s      $��775,93,10,514q�62   .��5t        -   5         .   . $	��124��5v      $	��699��5w      $
��Left=�6   $	��Top=�5x      ��5z      �� *PreBoletasPendentes+ 5{      �� *SelectedPreBoletasPendentes+ 5|        5}      $ Grupo de Carteira��6)    6D   �� *grupoCarteira+  5~      $ Carteira��6)    6;   �� *
carteira+  5      $ Ação��6)    67   �� *acao+  5�      $ Clase da Operação��6)    6D   �� *
classeOp+  5�      $ PU��6)    65   �� *pu+  5�      $ 
Quantidade��6)    6=   �� *
quantidade+  5�      $ Valor��6)    68   �� *valor+  5�      $ Conta Associada��6)    6B   �� *contaAssociada+  5�      $ 	Corretora��6)    6<   �� *	corretora+  5�      $ Status��6)    69   �� *status+5�      5�      �� 5�   
   $��Pré-Boletas Pendentes��6   $
��Left=�60   $��775,0,0,718q�6K   $��Bottom=�6`   $	��163��6{   $
��Bold"�6�   $��14(�6�   �� 5�   
   $
��Left=�6   $��41��60   $	��Top=�6<   $	��116��6T   $��
775,56,0,0q�6`   $	 
Horizontal=�6t   .+�5�      �� $��2,2,2,10q�6   $��2q�5�      
���   �$��Analisar��5�      $	��105��5�      $��Verdana)�5�      ��5�      �� ��5�      �� *CommandAnalisar+��5�      �� 5�      $
 0.5,1&�6*   $ 0.5,0&�6;   .��5�      � $ 	#FFD3D4D3��6'   $ 0Q�69   � 5�      $ 	LimeGreen��6'   $ 1Q�69   5�      5�      5�      �� 5�   
   $��Visible=�5�      $��Hidden=�5�      $��775,289,10,293q�62   .��5�        -   5         .   . $	��146��5�      $	��699��5�      $
��Left=�6   $	��Top=�5�      ��5�      �� *PreBoletasReprovadas+ 5�        5�      $ Grupo de Carteira��6)    6D   �� *grupoCarteira+  5�      $ Carteira��6)    6;   �� *
carteira+  5�      $ Ação��6)    67   �� *acao+  5�      $ Clase da Operação��6)    6D   �� *
classeOp+  5�      $ PU��6)    65   �� *pu+  5�      $ 
Quantidade��6)    6=   �� *
quantidade+  5�      $ Valor��6)    68   �� *valor+  5�      $ Conta Associada��6)    6B   �� *contaAssociada+  5�      $ 	Corretora��6)    6<   �� *	corretora+  5�      $ Status��6)    69   �� *status+5�      5�      �� 5�   
   $��Pré-Boletas Reprovadas��6   $
��Left=�61   $��775,0,0,485q�6L   $��Bottom=�6a   $	��175��6|   $
��Bold"�6�   $��14(�6�   �� 5�   
   -   5        $��44,476,1316,260q�5�      $��2q�5�      
���   �$��Criar Boletas��5�      $��Verdana)�5�       �� IsCancel . ��5�      �� 5�      $
 0.5,1&�6&   $ 0.5,0&�67   .��5�      � $ 	#FFD3D4D3��6#   $ 0Q�65   � 5�      $ 	LimeGreen��6#   $ 1Q�65   5�      5�      5�      5�      