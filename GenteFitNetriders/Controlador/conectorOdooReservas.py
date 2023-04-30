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
    archivo_xml = ET.parse('/Flota/python/reservas.xml')
    raiz = archivo_xml.getroot()
    for subraiz in raiz:
        do_write = object.execute(DB,uid,PASS,'x_reserva','create',[{
            'x_Estado':subraiz[0].text,
            'x_id':subraiz[1].text,
            'x_idClase':subraiz[2].text,
            'x_idUsuario':subraiz[3].text,

        }])
    print('Reservas Cargadas correctamente')
else:
    print('Error al conectar a Odoo')