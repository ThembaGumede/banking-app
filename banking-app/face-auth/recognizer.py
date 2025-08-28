import face_recognition
import cv2

def scan_face():
    video = cv2.VideoCapture(0)
    ret, frame = video.read()
    video.release()
    face_locations = face_recognition.face_locations(frame)
    return bool(face_locations)
