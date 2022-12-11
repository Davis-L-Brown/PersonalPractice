# copies what was achieved in version2.py, but sourced the ButtonHolder type from its own file
# allows for cleaner code
from buttonHolder import ButtonHolder
from PySide6.QtWidgets import QApplication
import sys 

app = QApplication(sys.argv)

window = ButtonHolder()

window.show()
app.exec()