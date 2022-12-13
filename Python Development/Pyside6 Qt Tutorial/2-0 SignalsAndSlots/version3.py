# version 3 : capture value from a slider

from PySide6.QtCore import Qt
from PySide6.QtWidgets import QApplication, QPushButton, QSlider

# the slot : respons when something happens
#def button_clicked(data):
#    print("You clicked the button : ", data)

def respond_to_slider(data):
    print("Slider moved to ", data)

app = QApplication()

slider = QSlider(Qt.Horizontal)
slider.setMinimum(1)
slider.setMaximum(100)
slider.setValue(25)

#button = QPushButton("Press me")
#button.setCheckable(True) 

slider.valueChanged.connect(respond_to_slider)
#button.clicked.connect(button_clicked)

slider.show()
#button.show()
app.exec()