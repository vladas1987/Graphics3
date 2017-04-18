using System;
using System.Collections;
using System.Text;
using Tao.OpenGl;

namespace LabDarbas_3
{
    class Pradzia
    {
        static void Main(string[] args)
        {
            int w = 400;
            int h = 400;
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_SINGLE | Glut.GLUT_RGB);
            Glut.glutInitWindowSize(w, h);
            Glut.glutInitWindowPosition(400, 300);
            Glut.glutCreateWindow("Pradzia");
            Init();
            Glut.glutDisplayFunc(new Glut.DisplayCallback(Piesk));
            Glut.glutCreateMenu(new Glut.CreateMenuCallback(Menu));
            Glut.glutAddMenuEntry("(1)Ketvirtis is virsaus", 1);
            Glut.glutAddMenuEntry("(2)Figura is virsaus", 2);
            Glut.glutAddMenuEntry("(3)Figura is sono", 3);
            Glut.glutAddMenuEntry("(4)Fugura paversta", 4);
            Glut.glutAddMenuEntry("(5)Sumazint, pasukt ir pastumt", 5);
            Glut.glutAddMenuEntry("(6)glu.Perspective", 6);
            Glut.glutAddMenuEntry("(7)glFrustum", 7);
            Glut.glutAddMenuEntry("Astuntas punktas", 8);
            Glut.glutAddMenuEntry("Pabaiga", 9);
            Glut.glutAttachMenu(Glut.GLUT_RIGHT_BUTTON);
            Glut.glutMainLoop();
        }

        static void Init()
        {
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            Gl.glColor3f(102 / 256f, 100 / 256f, 256 / 256f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
        }

        static void Piesk(float r, float g, float b)
        {
            Gl.glColor3f(0f, 0f, 1f);
            Ketvirtis();
            Gl.glRotated(90, 0.0, 0.0, 1.0);
            Gl.glColor3f(0f, 0f, 1f);
            Ketvirtis();
            Gl.glRotated(90, 0.0, 0.0, 1.0);
            Gl.glColor3f(0f, 0f, 1f);
            Ketvirtis();
            Gl.glRotated(90, 0.0, 0.0, 1.0);
            Gl.glColor3f(0f, 0f, 1f);
            Ketvirtis();
            Gl.glRotated(90, 0.0, 0.0, 1.0);
        }

        static void Ketvirtis()
        {
            float[] apacia = {    0.0f, -0.2f, -0.1f,
                                  0.0f, -0.4f, 0.0f,
                                  0.2f, -0.5f, 0.0f,
                                  0.2f, -0.3f, 0.0f,
                                  0.3f, -0.2f, 0.0f,
                                  0.5f, -0.2f, 0.0f,
                                  0.4f, 0.0f, 0.0f,
                                  0.2f, 0.0f, -0.1f
                            };
            float[] priekis = {0.2f, -0.3f, 0.0f,
                                   0.2f, -0.3f, 0.3f,
                                   0.3f, -0.2f, 0.3f,
                                   0.3f, -0.2f, 0.0f
                            };
            float[] desnys_sonas = {    0.5f, -0.2f, 0.0f,
                                   0.4f, 0.0f, 0.0f,
                                   0.4f, 0.0f, 0.3f,
                                   0.5f, -0.2f, 0.3f
                            };
            float[] kairys_sonas = {    0.0f, -0.4f, 0.0f,
                                   0.2f, -0.5f, 0.0f,
                                   0.2f, -0.5f, 0.3f,
                                   0.0f, -0.4f, 0.3f
                            };
            float[] desnys_galas = {    0.0f, -0.4f, 0.0f,
                                   0.0f, -0.4f, 0.3f,
                                   0.0f, -0.2f, 0.4f,
                                   0.0f, -0.2f, -0.1f
                            };
            float[] kairys_galas = {    0.2f, 0.0f, -0.1f,
                                   0.2f, 0.0f, 0.4f,
                                   0.4f, 0.0f, 0.3f,
                                   0.4f, 0.0f, 0.0f
                            };
            float[] galas = {    0.0f, -0.2f, -0.1f,
                                 0.0f, -0.2f, 0.4f,
                                 0.2f, 0.0f, 0.4f,
                                 0.2f, 0.0f, -0.1f
                            };
            float[] virsus = {    0.0f, -0.2f, 0.4f,
                                  0.0f, -0.4f, 0.3f,
                                  0.2f, -0.5f, 0.3f,
                                  0.2f, -0.3f, 0.3f,
                                  0.3f, -0.2f, 0.3f,
                                  0.5f, -0.2f, 0.3f,
                                  0.4f, 0.0f, 0.3f,
                                  0.2f, 0.0f, 0.4f
                            };
            float[] desnys_virsus = {    0.3f, -0.2f, 0.0f,
                                    0.3f, -0.2f, 0.3f,
                                    0.5f, -0.2f, 0.3f,
                                    0.5f, -0.2f, 0.0f
                                };

            float[] kairys_virsus = {    0.2f, -0.5f, 0.0f,
                                    0.2f, -0.5f, 0.3f,
                                    0.2f, -0.3f, 0.3f,
                                    0.2f, -0.3f, 0.0f
                                };
            float[] ItoIII = {      0.0f, -0.2f, -0.1f,
                                    0.2f, -0.5f, 0.0f,
                                    0.2f, -0.5f, 0.3f,
                                    0.0f, -0.2f, 0.4f
                                };
            float[] ItoIV = {       0.0f, -0.2f, -0.1f,
                                    0.2f, -0.3f, 0.0f,
                                    0.2f, -0.3f, 0.3f,
                                    0.0f, -0.2f, 0.4f
                                };
            float[] ItoII = {       0.0f, -0.2f, -0.1f,
                                    0.0f, -0.4f, 0.0f,
                                    0.0f, -0.4f, 0.3f,
                                    0.0f, -0.2f, 0.4f
                                };
            float[] VIIItoV = {     0.2f, 0.0f, -0.1f,
                                    0.2f, 0.0f, 0.4f,
                                    0.3f, -0.2f, 0.3f,
                                    0.3f, -0.2f, 0.0f
                                };

            float[] VIIItoIV = {    0.2f, 0.0f, -0.1f,
                                    0.2f, -0.3f, 0.0f,
                                    0.2f, -0.3f, 0.3f,
                                    0.2f, 0.0f, 0.4f
                                };
            float[] VIIItoVI = {    0.2f, 0.0f, -0.1f,
                                    0.2f, 0.0f, 0.4f,
                                    0.5f, -0.2f, 0.3f,
                                    0.5f, -0.2f, 0.0f
                                };

            Gl.glEnableClientState(Gl.GL_VERTEX_ARRAY);
            Gl.glLineWidth(2);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, apacia);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 8);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, priekis);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, desnys_sonas);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, kairys_sonas);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, desnys_galas);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, kairys_galas);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, galas);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, virsus);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 8);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, desnys_virsus);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, kairys_virsus);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, ItoIII);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, ItoIV);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, ItoII);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, VIIItoV);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, VIIItoIV);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, VIIItoVI);
            Gl.glDrawArrays(Gl.GL_LINE_LOOP, 0, 4);

            Gl.glFlush();
            Gl.glDisableClientState(Gl.GL_VERTEX_ARRAY | Gl.GL_COLOR_ARRAY);
        }

        static void Rodyk1()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Ketvirtis();
        }

        static void Rodyk2()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluLookAt(0, 1, 0, 0, 0, 0, 0, 1, -1);
            Piesk(0 / 256f, 0 / 256f, 256 / 256f);
            Gl.glLoadIdentity();
        }

        static void Rodyk3()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glColor3f(0 / 256f, 0 / 256f, 256 / 256f);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glRotated(-90, 1.0, 0.0, 0.0);
            Gl.glTranslated(0, 0, 1);
            Glu.gluLookAt(0, 1, 0, 0, 0, 0, 0, 1, -1);
            Piesk(0 / 256f, 0 / 256f, 256 / 256f);
            Gl.glLoadIdentity();
        }

        static void Rodyk4()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glColor3f(0 / 256f, 0 / 256f, 256 / 256f);
            Gl.glOrtho(-1.5, 1.5, -1.5, 1.5, 5, -10);

            float[] rotateX = {1,0,0,0,
                                  0,(float)Math.Cos(-45*Math.PI/180), (float)-Math.Sin(-45*Math.PI/180), 0,
                                  0,(float)Math.Sin(-45*Math.PI/180), (float)Math.Cos(-45*Math.PI/180), 0,
                                   0, 0, 0, 1};
            float[] rotateY = {(float)Math.Cos(20*Math.PI/180), 0, (float)Math.Sin(20*Math.PI/180), 0,
                                  0,1,0,0,
                                  (float)-Math.Sin(20*Math.PI/180), 0, (float)Math.Cos(20*Math.PI/180), 0,
                                  0, 0, 0, 1};

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glMultMatrixf(rotateX);
            Gl.glMultMatrixf(rotateY);
            Piesk(0 / 256f, 0 / 256f, 256 / 256f);
            Gl.glLoadIdentity();
        }

        static void Rodyk5()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glColor3f(0 / 256f, 0 / 256f, 256 / 256f);
            Gl.glOrtho(-1.5, 1.5, -1.5, 1.5, 5, -10);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Piesk(0 / 256f, 0 / 256f, 256 / 256f);

            float[] bendramatrixa = {(float)Math.Cos(45*Math.PI/180), (float)Math.Sin(45*Math.PI/180),    0, 0,
                                  (float)-Math.Sin(45*Math.PI/180), (float)Math.Cos(45*Math.PI/180), 0, 0,
                                  0, 0, 1, 0,
                                  1.2f, 1.2f, 0.2f, 3.0f};

            Gl.glMultMatrixf(bendramatrixa);
            Piesk(0 / 256f, 0 / 256f, 256 / 256f);
        }

        static void Rodyk6()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Glu.gluLookAt(0, 1, 2, 0, 0, 0, 0, 1, 0);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(-60, 1, 1, 3);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Piesk(0 / 256f, 0 / 256f, 256 / 256f);
            Gl.glLoadIdentity();
        }

        static void Rodyk7()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Glu.gluLookAt(0, 1, 2, 0, 0, 0, 0, 1, 0);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glFrustum(-1, 1, -1, 1, 1, 10);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Piesk(0 / 256f, 0 / 256f, 256 / 256f);
            Gl.glLoadIdentity();
        }

        static void Rodyk8()
        {
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Glut.glutInitDisplayMode(Glut.GLUT_DEPTH | Glut.GLUT_SINGLE | Glut.GLUT_RGB);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glColor3f(0 / 256f, 0 / 256f, 256 / 256f);
            Gl.glOrtho(-1.5, 1.5, -1.5, 1.5, 5, -10);

            float[] rotateX = {1,0,0,0,
                                  0,(float)Math.Cos(-30*Math.PI/180), (float)-Math.Sin(-30*Math.PI/180), 0,
                                  0,(float)Math.Sin(-30*Math.PI/180), (float)Math.Cos(-30*Math.PI/180), 0,
                                  0, 0, 0, 1};
            float[] rotateY = {(float)Math.Cos(10*Math.PI/180), 0, (float)Math.Sin(10*Math.PI/180), 0,
                                  0,1,0,0,
                                  (float)-Math.Sin(10*Math.PI/180), 0, (float)Math.Cos(10*Math.PI/180), 0,
                                  0, 0, 0, 1};

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glMultMatrixf(rotateX);
            Gl.glMultMatrixf(rotateY);
            Piesk();
            Gl.glLoadIdentity();
        }

        static void Menu(int i)
        {
            switch (i)
            {
                case 1:
                    Rodyk1();
                    break;
                case 2:
                    Rodyk3();
                    break;
                case 3:
                    Rodyk2();
                    break;
                case 4:
                    Rodyk4();
                    break;
                case 5:
                    Rodyk5();
                    break;
                case 6:
                    Rodyk6();
                    break;
                case 7:
                    Rodyk7();
                    break;
                case 8:
                    Rodyk8();
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
            }
        }

        static void Piesk()
        {
            Gl.glColor3f(0f, 0f, 1f);
            KetvirtisS();
            Gl.glRotated(90, 0.0, 0.0, 1.0);
            Gl.glColor3f(0f, 0f, 1f);
            KetvirtisS();
            Gl.glRotated(90, 0.0, 0.0, 1.0);
            Gl.glColor3f(0f, 0f, 1f);
            KetvirtisS();
            Gl.glRotated(90, 0.0, 0.0, 1.0);
            Gl.glColor3f(0f, 0f, 1f);
            KetvirtisS();
            Gl.glRotated(90, 0.0, 0.0, 1.0);
        }

        static void KetvirtisS()
        {
            float[] apacia = { 0.0f, -0.4f, 0.0f,
                               0.2f, -0.5f, 0.0f,
                               0.0f, -0.2f, -0.1f,
                               0.2f, -0.3f, 0.0f,
                               0.2f, 0.0f, -0.1f,
                               0.3f, -0.2f, 0.0f,
                               0.4f, 0.0f, 0.0f,
                               0.5f, -0.2f, 0.0f
                            };
            float[] sonai = { 0.0f, -0.4f, 0.0f,
                              0.0f, -0.4f, 0.3f,
                              0.0f, -0.2f, -0.1f,
                              0.0f, -0.2f, 0.4f,
                              0.2f, 0.0f, -0.1f,
                              0.2f, 0.0f, 0.4f,
                              0.4f, 0.0f, 0.0f,
                              0.4f, 0.0f, 0.3f,
                              0.5f, -0.2f, 0.0f,
                              0.5f, -0.2f, 0.3f,
                              0.3f, -0.2f, 0.0f,
                              0.3f, -0.2f, 0.3f,
                              0.2f, -0.3f, 0.0f,
                              0.2f, -0.3f, 0.3f,
                              0.2f, -0.5f, 0.0f,
                              0.2f, -0.5f, 0.3f,
                            };
            float[] virsus = { 0.0f, -0.4f, 0.3f,
                              0.2f, -0.5f, 0.3f,
                              0.0f, -0.2f, 0.4f,
                              0.2f, -0.3f, 0.3f,
                              0.2f, 0.0f, 0.4f,
                              0.3f, -0.2f, 0.3f,
                              0.4f, 0.0f, 0.3f,
                              0.5f, -0.2f, 0.3f
                            };
            Gl.glEnableClientState(Gl.GL_VERTEX_ARRAY);
            Gl.glLineWidth(2);
            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, apacia);
            Gl.glDrawArrays(Gl.GL_QUAD_STRIP, 0, 8);
            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, sonai);
            Gl.glDrawArrays(Gl.GL_QUAD_STRIP, 0, 16);
            Gl.glVertexPointer(3, Gl.GL_FLOAT, 0, virsus);
            Gl.glDrawArrays(Gl.GL_QUAD_STRIP, 0, 8);
            Gl.glFlush();
            Gl.glDisableClientState(Gl.GL_VERTEX_ARRAY | Gl.GL_COLOR_ARRAY);
        }
    }
}

