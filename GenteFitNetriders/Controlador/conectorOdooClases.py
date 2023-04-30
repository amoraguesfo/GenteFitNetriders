import xml.etree.ElementTree as ET
import xmlrpc.client

url = 'http://localhost:8069/xmlrpc/'
DB='odooBD'
USER='lmenaar@uoc.edu'
PASS='Eresuncansin0'

common_proxy = xmlrpc.client.ServerProxy(url+'common')
object = xmlrpc.client.ServerProxy(url+'object')
uid = common_proxy.login(DB,USER, PASS)

#Autentificacion
#uid = common.authenticate(DB,USER, PASS, {})

if uid:
    archivo_xml = ET.parse('/GenteFitNetriders/python/clases.xml')
    raiz = archivo_xml.getroot()
    for subraiz in raiz:
        do_write = object.execute(DB,uid,PASS,'x_Clases','create',[{
            'x_Duracion':subraiz[0].text,
            'x_Fecha':subraiz[1].text,
            'x_Hora':subraiz[2].text,
            'x_Nombre':subraiz[3].text,
            'x_Plazas':subraiz[4].text,
            'x_Profesor':subraiz[5].text,
            'x_id':subraiz[6].text,
            }])
    print('Clases Cargadas correctamente')
else:
    print('Error al conectar a Odoo')