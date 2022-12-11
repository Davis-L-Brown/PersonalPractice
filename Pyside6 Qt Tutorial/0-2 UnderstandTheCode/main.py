#Importing the python modules we need
from PySide6.QtWidgets import QApplication, QWidget
#sys is responsible for processing command line arguments
import sys 

#app is an object, it is like a wrapper that contains the entire application
#sys.argv creates a list of command line arguements that will be passed to the QApplication wrapper
app = QApplication(sys.argv)

#QWidget recieves mouse keyboard and other events from the window system that app contains
#for more information, view the documentation at: https://doc.qt.io/qtforpython-5/PySide2/QtWidgets/QWidget.html
window = QWidget()
window.show() 

#start the event loop
app.exec()