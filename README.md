# OOP_ClassProject

## Calculator

Programming calculator's functions and a special Paint form to display various geometrical shapes.

Some of interesting parts of the project is:

**1. Poland Equation**

Create a stack then push all elements of the equation into this stack. When an operator is caught, `stack.pop()` the last 2 numerical elements out.

                `if (IsOperator(s))

                {
                
                    if(binaryOperatorList.Contains(s))
                    
                    {
                        d1 = ReadValue(stack.Pop(), dict);
                        
                        d2 = ReadValue(stack.Pop(), dict);
                        
                        result = EvalBinaryOperator(d2, d1, s);
                        
                        stack.Push(result);
                        
                    }
                    
                    if(unaryOperatorList.Contains(s))
                    
                    {
                    
                        d1 = ReadValue(stack.Pop(), dict);
                        
                        result = EvalUnaryOperator(d1, s);
                        
                        stack.Push(result);
                        
                    }
                    
                }
                
                else
                
                    stack.Push(s);`
                    
**2. Draw Parallelopiped and Cuboid**

Create a parallelogram first, before drawing-line function connects the 2 of them to form a parallelopiped.

        `private void btnPrl_Clicked(Pen p, Point p1, Point p2, Point p3){
        
            Point p4 = new Point(p2.X + p3.X - p1.X, p2.Y + p3.Y - p1.Y);
            
            g.DrawLine(p, p1, p2); g.DrawLine(p, p1, p3); g.DrawLine(p, p2, p4); g.DrawLine(p, p3, p4);
            
            pictureBox1.Image = bmp;
            
        }`
        
To connect 2 parallelograms:

         `private void btnPrlp_Clicked(Pen p, Point p1, Point p2, Point p3, Point p_1){
         
            Point p4 = new Point(p2.X+p3.X-p1.X, p2.Y+p3.Y-p1.Y);
            
            Point p1Top_1 = new Point(p_1.X - p1.X, p_1.Y - p1.Y);
            
            Point p_2 = AddPoint(p2, p1Top_1); Point p_3 = AddPoint(p3, p1Top_1); Point p_4 = AddPoint(p4, p1Top_1);
            
            //Point p_2 = new Point(p_1.X + p2.X - p1.X, p_1.Y + p2.Y - p1.Y); 
            
            //Point p_3 = new Point(p_1.X + p3.X - p1.X, p_1.Y + p3.Y - p1.Y); 
            
            //Point p_4 = new Point(p_2.X + p_3.X - p_1.X, p_2.Y + p_3.Y - p_1.Y);

            
            btnPrl_Clicked(p,p1,p2,p3); btnPrl_Clicked(p,p_1,p_2,p_3);
            
            g.DrawLine(p,p1,p_1); g.DrawLine(p,p2,p_2); g.DrawLine(p,p3,p_3); g.DrawLine(p,p4,p_4);
            
            listBox1.Items.Add("p1.X: " + p1.X + "   p1.Y: " + p1.Y); listBox1.Items.Add("p2.X: " + p2.X + "   p2.Y: " + p2.Y); listBox1.Items.Add("p3.X: " + p3.X + "   p3.Y: " + p3.Y); listBox1.Items.Add("p4.X: " + p4.X + "   p4.Y: " + p4.Y);
            
            listBox1.Items.Add("p_1.X: " + p_1.X + "   p_1.Y: " + p_1.Y); listBox1.Items.Add("p_2.X: " + p_2.X + "   p_2.Y: " + p_2.Y); listBox1.Items.Add("p_3.X: " + p_3.X + "   p_3.Y: " + p_3.Y); listBox1.Items.Add("p_4.X: " + p_4.X + "   p_4.Y: " + p_4.Y);
            
            comboBox1.Enabled = true;
            
            pictureBox1.Image = bmp;
        }`
