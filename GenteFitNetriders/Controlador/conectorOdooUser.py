import xml.etree.ElementTree as ET
import xmlrpc.client

url ='http://localhost:8069/xmlrpc/'
DB='odooBD'
USER='lmenaar@uoc.edu'
PASS='Eresuncansin0'

common_proxy = xmlrpc.client.ServerProxy(url+'common')
object = xmlrpc.client.ServerProxy(url+'object')
uid = common_proxy.login(DB,USER, PASS)

#Autentificacion
#uid = common.authenticate(DB,USER, PASS, {})

if uid:
    archivo_xml = ET.parse('/Flota/python/user.xml')
    raiz = archivo_xml.getroot()
    for subraiz in raiz:
        do_write = object.execute(DB,uid,PASS,'x_usuario','create',[{
            'x_Edad':subraiz[0].text,
            'x_Email':subraiz[1].text,
            'x_Nombre':subraiz[2].text,
            'x_Password':subraiz[3].text,
            'x_Sexo':subraiz[4].text,
            'x_Telefono':subraiz[5].text,
            'x_id':subraiz[6].text,
            }])
    print('Usuarios Cargados correctamente')
else:
    print('Error al conectar a Odoo')