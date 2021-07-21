using System;
using System.Collections.Generic;
using System.Threading;
using AppPatronesDiseño.Helpers.Dto;
using AppPatronesDiseño.Patrones;
using AppPatronesDiseño.Patrones._1.Builder;
using AppPatronesDiseño.Patrones._1_2.FluentBuilder;
using AppPatronesDiseño.Patrones_comportamiento._1.ChainResponsability;
using AppPatronesDiseño.Patrones_comportamiento._2.Command;
using AppPatronesDiseño.Patrones_comportamiento._3.Interpreter;
using AppPatronesDiseño.Patrones_comportamiento._4.Iterator;
using AppPatronesDiseño.Patrones_comportamiento._5.Memento;
using AppPatronesDiseño.Patrones_comportamiento._6.Mediator;
using AppPatronesDiseño.Patrones_comportamiento._7.NullObject;
using AppPatronesDiseño.Patrones_comportamiento._8.Observer;
using AppPatronesDiseño.Patrones_comportamiento._9.State;
using AppPatronesDiseño.Patrones_comportamiento._10.Strategy;
using AppPatronesDiseño.Patrones_comportamiento._11.TemplateMethod;
using AppPatronesDiseño.Patrones_creacionales._2.Factory._1.Factory;
using AppPatronesDiseño.Patrones_creacionales._2.Factory._2.Abstract_Factory;
using AppPatronesDiseño.Patrones_creacionales._3.Prototype;
using AppPatronesDiseño.Patrones_creacionales._4.Singleton;
using AppPatronesDiseño.Patrones_estructurales._1.Adapter;
using AppPatronesDiseño.Patrones_estructurales._2.Bridge;
using AppPatronesDiseño.Patrones_estructurales._3.Composite;
using AppPatronesDiseño.Patrones_estructurales._4.Decorator;
using AppPatronesDiseño.Patrones_estructurales._5.Facade;
using AppPatronesDiseño.Patrones_estructurales._6.FlyWeight;
using AppPatronesDiseño.Patrones_estructurales._7.Proxy;
using AppPatronesDiseño.Principios;
using AppPatronesDiseño.Procesamiento;
using AppPatronesDiseño.Patrones_comportamiento._12.Visitor;

namespace AppPatronesDiseño
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Principios

            var arrayPrincipios = new bool[5] { false, false, false, false, false };

            #region SRP
            if (arrayPrincipios[0])
            {
                // Crear patron de tipo SRP
                var patron = new DtoPrincipio() {
                    Nombre = EnumPrincipios.SingleResponsibilityPrinciple,
                    Detalle = "Patron - Principio de simple responsabilidad"
                };

                // Procesar SRP
                new SingleResponsibilityPrinciple().MostrarMensaje(patron);

                // SRP Ejemplo
                // Cargar patrones
                SingleResponsabilityPrinciple_Ejemplo.AgregarPatron(new DtoPrincipio() { Nombre = EnumPrincipios.SingleResponsibilityPrinciple, Detalle = "Principio de simple responsabilidad" });
                SingleResponsabilityPrinciple_Ejemplo.AgregarPatron(new DtoPrincipio() { Nombre = EnumPrincipios.OpenClosedPrinciple, Detalle = "Principio de abierto/cerrado" });
                // Listar patrones
                Console.WriteLine(SingleResponsabilityPrinciple_Ejemplo.ListarPatrones());
            }
            #endregion

            #region OCP
            if (arrayPrincipios[1])
            {
                var listaFormas = new List<IShape>()
                {
                    new DtoTriangle(),
                    new DtoRectangle(0, 0),
                    new DtoSquare(0, 0)
                };

                OpenClosedPrinciple.MostrarFormas(listaFormas);
            }
            #endregion

            #region LSP
            if (arrayPrincipios[2])
                LiskovSubstitutionPrinciple.EjemploListarFormas();
            #endregion

            #region ISP
            if (arrayPrincipios[3])
                InterfaceSegregationPrinciple.ListarInterfacesHeredadas(typeof(string));
            #endregion

            #region DIP
            if (arrayPrincipios[4])
            {
                // Codigo sin aplicar el principio D
                var dip = new DependencyInversionPrinciple();
                dip.Constructor(new DtoTriangle(), new DtoRectangle(0, 0), new DtoSquare(0, 0));

                dip.ConteoTriangle();
                dip.ConteoRectangle();
                dip.ConteoSquare();

                // Codigo aplicando el principio D
                dip.Constructor(new List<IShape>()
                {
                    new DtoTriangle(),
                    new DtoRectangle(0, 0),
                    new DtoSquare(0, 0),
                    new DtoSquare(0, 0)
                });

                dip.ConteoShape();
            }
            #endregion

            #endregion

            #region Patrones creacionales

            #region 1.Builder

            // Caracteristicas principales
            // 1. La clase Request es mutable y siempre debe serlo para sufrir cambios de valores

            //var request = new Request();
            //request.CargarValores(false, false, @"https:\\www.google.com", null, null);

            //var requestAssembly = new RequestAssembly(request);
            //Console.WriteLine(requestAssembly.Assemble());

            //// Re-envio la peticion
            //request.CargarValores(false, false, @"https:\\www.google.com", null, null);
            //Console.WriteLine(requestAssembly.Assemble());

            //// Obtener objeto Request del Assembly
            //var requestFromBuilder = requestAssembly.ObtenerRequest();

            //// Fluent Builder
            //var fluentRequest = new FluentRequestBuilder()
            //    .CargarValores(false, false, @"https:\\www.google.com", null, null)
            //    .AgregarParametrosCabecera()
            //    .AgregarParametrosCuerpo();

            //Console.WriteLine(fluentRequest.ArmarPeticionAsync());

            #endregion

            #region 2.Factory

            //// Factory
            //var user = User.Factory.AddWithoutDate(1, "example");

            //// Abstract Factory
            //var userFactoryAdmin = new UserFactory(new UserAdmin());
            //Console.WriteLine(userFactoryAdmin.GetUserType());

            //var userFactoryPro = new UserFactory(new UserPro());
            //Console.WriteLine(userFactoryPro.GetUserType());

            #endregion

            #region 3.Prototype

            // Caracteristicas principales
            // 1. La funcion principal de este patron es copiar un objeto existente
            //    Esto permite ahorrar recursos, cuesta menos copiar que crear
            // 2. Hay dos formas de copiar:
            //    Deep Copy: realiza un copiado recurso de un objeto, obteniendo asi
            //        referencias, metodos, propertys, herencias, etc
            //    Shallow Copy: solo realiza el copiado del objeto principal
            //        y obtiene las referencias del resto de los valores

            // Shallow Copy
            //var userICloneable = new UserICloneable();
            //userICloneable.Id = 1;
            //userICloneable.FirstName = "Kurt";
            //userICloneable.LastName = "Weller";
            //userICloneable.CountryOfBirth = new UserICloneable.Country() { Name = "USA" };
            //// Copy
            //var copyUserICloneable = (UserICloneable)userICloneable.Clone();
            //copyUserICloneable.Id = 2;
            //copyUserICloneable.FirstName = "Jane";
            //copyUserICloneable.LastName = "Doe";
            //copyUserICloneable.CountryOfBirth.Name = "Africa";
            //// Mostrar resultados
            //Console.WriteLine(userICloneable.GetDetails());
            //Console.WriteLine(copyUserICloneable.GetDetails());

            // DeepCopy
            //var userPrototype = new UserPrototype();
            //userPrototype.Id = 1;
            //userPrototype.FirstName = "Kurt";
            //userPrototype.LastName = "Weller";
            //userPrototype.CountryOfBirth = new UserPrototype.Country() { Name = "USA" };
            //// Copy
            //var copyUserPrototype = DeepCopyHelper.DeepCopy<UserPrototype>(userPrototype);
            //copyUserPrototype.Id = 2;
            //copyUserPrototype.FirstName = "Jane";
            //copyUserPrototype.LastName = "Doe";
            //copyUserPrototype.CountryOfBirth = new UserPrototype.Country() { Name = "Africa" };
            //// Mostrar resultados
            //Console.WriteLine(userPrototype.GetDetails());
            //Console.WriteLine(copyUserPrototype.GetDetails());

            #endregion

            #region 4.Singleton

            // Caracteristicas principales
            // 1. La funcion principal de este patron es el de mantener un objeto instanciado
            //    a traves de toda la ejecucion del programa, por ejemplo se creo la clase Logger
            //    que no requiere una nueva instancia cada vez que se use, es una clase inmutable

            //LoggerSingleton.Instance.Log("Test1");
            //LoggerSingleton.Instance.Log("Test2");
            //LoggerSingleton.Instance.Log("Test3");

            #endregion

            #endregion

            #region Patrones estructurales

            #region 1.Adapter

            // Caracteristicas principales
            // 1. La funcion principal de la clase Adapter es de proporcionar
            //    metodos que permitan adaptar un objeto de un tipo a otro

            //var adapterDetailXml = new AdapterDetail(
            //    new Detail(
            //        "<tests><test></test></tests>",
            //        EnumTypeDetail.XML
            //    )
            //);
            //var xDoc1 = adapterDetailXml.StringToXDocument();
            //var jObject1 = adapterDetailXml.StringToJObject();

            //var adapterDetailJson = new AdapterDetail(
            //    new Detail(
            //        "{\"tests\":{\"test\":null}}",
            //        EnumTypeDetail.JSON
            //    )
            //);
            //var xDoc2 = adapterDetailJson.StringToXDocument();
            //var jObject2 = adapterDetailJson.StringToJObject();

            #endregion

            #region 2.Bridge

            // Caracteristicas principales
            // 1. La funcion principal de la clase Bridge es de ser un puente entre las clases
            //    de alto nivel y las clases de bajo nivel

            //// Xml
            //var xmlClass = new XmlClass(new XmlFormatter());
            //xmlClass.XmlCrude = "<?xml version=\"1.0\"?><book><author>Lewis, C.S.</author><title>The Four Loves</title></book>";
            //Console.WriteLine(xmlClass.FormatString());

            //// Json
            //var jsonClass = new JsonClass(new JsonFormatter());
            //jsonClass.JsonCrude = "{ \"author\": \"Lewis, C.S.\", \"title\": \"The Four Loves\" }";
            //Console.WriteLine(jsonClass.FormatString());

            #endregion

            #region 3.Composite

            // Caracteristicas principales
            // 1. La funcion principal de la clase Composite es de implementar la clase base
            //    y agregar la funcionalidad basica en base a un conjunto de objetos
            //    de tipo de la clase base

            //// Crear diferentes tipos de usuarios
            //var normalUser = new UserC(1, new DateTime(2020, 03, 29, 12, 15, 01));
            //var managerUser = new UserC(2, new DateTime(2020, 03, 29, 12, 15, 02));
            //var adminUser = new UserC(3, new DateTime(2020, 03, 29, 12, 15, 03));
            //var hostUser = new UserC(4, new DateTime(2020, 03, 29, 12, 15, 04));
            //var ownerUser = new UserC(5, new DateTime(2020, 03, 29, 12, 15, 05));

            //// Inicios de sesion
            //var userCComposite = new UserCComposite();
            //userCComposite.Add(normalUser);
            //userCComposite.Add(managerUser);
            //userCComposite.Add(adminUser);
            //userCComposite.Add(hostUser);
            //userCComposite.Add(ownerUser);

            //// Conteo de usuarios en linea
            //Console.WriteLine(userCComposite.Count());

            //// Log Out
            //userCComposite.Remove(normalUser);

            //// Conteo de usuarios en linea
            //Console.WriteLine(userCComposite.Count());

            #endregion

            #region 4.Decorator

            // Caracteristicas principales
            // 1. La funcion principal del patron Decorator es instanciar decorator entre si
            //    y la logica se mantiene en el componente principal
            //    decorator es simplemente para añadir un valor en especifico en base a la clase

            //var adminRol = new DecoratorAdministrative(new DecoratorConfiguration(new DecoratorFinancial(new DecoratorTools(new AdminRol()))));
            //Console.WriteLine(adminRol.GetRol());

            #endregion

            #region 5.Facade

            // Caracteristicas principales
            // 1. La unica funcion de la clase Facade es de ejecutar cierto codigo en un solo lugar
            //    y con un solo llamado, esta clase no implementa logica

            //var facadeReporte = new FacadeReport(new ProcessReport());
            //facadeReporte.GenerateReport();

            #endregion

            #region 6.FlyWeight

            // Caracteristicas principales
            // 1. La unica funcion de la clase FactoryCharacter es de mantener en memoria los mismos tipos de objetos
            //    para retornarlos y evitar nuevas instancias
            // 2. En la clase FactoryCharacter pasa lo mismo que con el patron BuilderFluent, siempre habra codigo en esta clase
            //    No se repite codigo pero existe en algun lugar

            //var flyWeightCharacters = new FactoryCharacter();
            //// Añadir Terrorist
            //flyWeightCharacters.AddCharacter(EnumTypeCharacter.Terrorist);
            //flyWeightCharacters.AddCharacter(EnumTypeCharacter.Terrorist);
            //// Añadir CounterTerrorist
            //flyWeightCharacters.AddCharacter(EnumTypeCharacter.CounterTerrorist);
            //flyWeightCharacters.AddCharacter(EnumTypeCharacter.CounterTerrorist);

            //// Mostrar conteos
            //Console.WriteLine(flyWeightCharacters.GetTotalCountForType(EnumTypeCharacter.Terrorist));
            //Console.WriteLine(flyWeightCharacters.GetTotalCountForType(EnumTypeCharacter.CounterTerrorist));
            //Console.WriteLine(flyWeightCharacters.GetTotalCount());

            #endregion

            #region 7.Proxy

            // Caracteristicas principales
            // 1. La unica funcion del patron Proxy es de proveer un sustituto de un tipo de objeto determinado
            //    su objetivo principal es de ser una capaz intermedia que agregue mas seguridad y permita
            //    obtener informacion a traves de ella y no directamente a una fuente sensible de informacion

            //var user = new AccessProxy(new Manager());
            //Console.WriteLine(user.VerifyAccess());

            #endregion

            #endregion

            #region Patrones de comportamiento

            #region 1.ChainResponsability

            // Caracteristicas principales
            // 1. La funcion principal de este patron es de declarar varias responsables
            //    en una sola linea de procesos

            // Pedido
            //var smsRequest = new SmsRequest(101);
            //// Proveedores
            //var smallSuplier = new SmallSuplier(new SmallSpecification());
            //var massiveSuplier = new MassiveSuplier(new MassiveSpecification());
            //// Declarar sucesor
            //smallSuplier.SetSuccessor(massiveSuplier);

            //// Procesar
            //smallSuplier.HandleRequest(smsRequest);

            #endregion

            #region 2.Command

            // Caracteristicas principales
            // 1. La funcion principal de este patron es de usar la clase Command para invocar los metodos
            //    que deseemos em base al Enum de acciones, recibiendo como parametro la clase de alto nivel

            //// Crear y setear Processor
            //var processor = new Processor();
            //processor.SetAction(() => Console.WriteLine("Ejecucion de un Action"));
            //processor.SetSleepTime(5000);
            //// Crear y setear Command
            //var command = new Command(processor);
            //command.SetAction(EnumAction.RunAction);
            //command.Invoke();

            #endregion

            #region 3.Interpreter

            // Caracteristicas principales
            // 1. La funcion principal de este patron es de tener un metodo Interpret
            //    que procese una o mas objetos del tipo de la interfaz requerida

            //var firstNumber = new FloatExpression(1.25);
            //var secondNumber = new FloatExpression("0,33");
            //// Mostrar resultado
            //Console.WriteLine(new AdditionExpresion(firstNumber, secondNumber).Interpret());

            #endregion

            #region 4.Iterator

            // Caracteristicas principales
            // 1. La funcion principal de este patron es de tener una clase Iterator de un tipo
            //    y que contenga metodos para recorrer el objeto sea de tipo List, Stack, Array, etc
            //    este patron se usa mucho en PHP para recorrer colecciones de datos

            //// Crear Collection
            //var azureFaceCollection = new AzureFaceCollection
            //{
            //    new Face { Id = "1" },
            //    new Face { Id = "2" },
            //    new Face { Id = "3" }
            //};
            //// Crear Iterator
            //var azureFaceIterator = azureFaceCollection.Iterator();

            //// Recorrer Iterator con While
            //while(azureFaceIterator.HasNext())
            //{
            //    var face = azureFaceIterator.Next();
            //    Console.WriteLine($"AzureFace con Id: {face.Id}");
            //}

            #endregion

            #region 5.Memento

            // Caracteristicas principales
            // 1. La funcion principal de este patron es de persistir un registro de todas
            //    las acciones realizadas que implementen la clase Memento dependiendo de su tipo

            //var account = new Account();
            //account.Increase(1);
            //account.Increase(1);
            //account.Increase(1);
            //account.Decrease(1);
            //account.Increase(1);

            //// Balance
            //Console.WriteLine($"Balance: {account.GetBalance()}{Environment.NewLine}");
            //// Undo
            //Console.WriteLine($"Undo: {account.Undo()?.Value}");
            //Console.WriteLine($"Undo: {account.Undo()?.Value}");
            //Console.WriteLine($"Undo: {account.Undo()?.Value}");
            //Console.WriteLine($"Undo: {account.Undo()?.Value}");
            //Console.WriteLine($"Undo: {account.Undo()?.Value}");
            //Console.WriteLine($"Undo: {account.Undo()?.Value}");
            //// Redo
            //Console.WriteLine($"Redo: {account.Redo()?.Value}");
            //Console.WriteLine($"Redo: {account.Redo()?.Value}");
            //Console.WriteLine($"Redo: {account.Redo()?.Value}");
            //Console.WriteLine($"Redo: {account.Redo()?.Value}");
            //Console.WriteLine($"Redo: {account.Redo()?.Value}");
            //Console.WriteLine($"Redo: {account.Redo()?.Value}");

            #endregion

            #region 6.Mediator

            // Caracteristicas principales
            // 1. La funcion principal de este patron es de tener una clase Mediator que encapsule a un tipo
            //    para aplicar cierto procesamiento o logica

            //// Crear Action
            //Action action = (() => Thread.Sleep(5000));
            //// Crear Context y cargar Action
            //var context = new Context();
            //context.SetAction(action);

            //// Crear Mediator
            //var mediator = new Mediator(context);
            //// Procesar
            //Console.WriteLine(mediator.IsAvailable());
            //mediator.ProcessAsync();
            //Console.WriteLine(mediator.IsAvailable());
            //mediator.ProcessAsync();

            #endregion

            #region 7.NullObject

            // Caracteristicas principales
            // 1. La funcion principal de este patron es de tener una clase con valores Null
            //    que tenga la implementacion de una interfaz entre varias clases
            //    esto es con el objetivo de que si no se pueda ejecutar una accion, entonces
            //    podamos obtener el valor null y evitar errores de referencias nulas

            //// Cargar repositorio
            //var repositoryOperation = new RepositoryOperation();
            //// Tratar de obtener la operacion
            //var operation = repositoryOperation.GetOperation("TEST");

            //// Verificar el objeto recibido
            //if (operation == null)
            //    Console.WriteLine("Operation is NULL");

            #endregion

            #region 8.Observer

            // Caracteristicas principales
            // 1. La funcion principal de este patron es de tener una clase que se encarga de notificar
            //    a una coleccion de objetos sobre algun cambio en especifico, a traves de la llamada
            //    de un metodo implementado en una interfaz

            //// Crear Observer
            //var observer = new ServerObserver();
            //observer.Add(new Server("example1@example.com"));
            //observer.Add(new Server("example2@example.com"));
            //observer.Add(new Server("example3@example.com"));

            //observer.Process();
            //observer.Process();

            #endregion

            #region 9.State

            // Caracteristicas principales
            // 1. La funcion principal de este patron es de crear una coleccion que permita
            //    determinar las posibles acciones en un determinado estado
            //    Este patron se puede aplicar con codigo propio o con la libreria StateLess

            //var processState = new ProcessState();
            //Console.WriteLine(processState.GetTrafficLight());
            //// Setear proceso ocupado
            //processState.SetState(EnumState.Processing);
            //Console.WriteLine(processState.GetTrafficLight());
            //// Setear proceso desocupado
            //processState.SetState(EnumState.Waiting);
            //Console.WriteLine(processState.GetTrafficLight());

            #endregion

            #region 10.Strategy

            // Caracteristicas principales
            // 1. La funcion principal de este patron es de crear una clase Strategy
            //    que tenga un field del tipo interfaz para llamar a sus metodos

            //// Xml
            //var xmlFormatter = new XmlFormatterStrategy();
            //xmlFormatter.Start();
            //xmlFormatter.Middle("Test");
            //xmlFormatter.End();
            //// Html
            //var htmlFormatter = new HtmlFormatterStrategy();
            //htmlFormatter.Start();
            //htmlFormatter.Middle("Test");
            //htmlFormatter.End();

            //var process = new TextProcess();
            //// Xml
            //process.SetFormatter(xmlFormatter);
            //Console.WriteLine(process.Process());
            //// Html
            //process.SetFormatter(htmlFormatter);
            //Console.WriteLine(process.Process());

            #endregion

            #region 11.TemplateMethod

            // Caracteristicas principales
            // 1. La funcion principal de este patron es de crear una clase abstracta
            // que tenga metodos abstractos para ser usados cuando la hereden

            //// Admin
            //var admin = new UTAdmin();
            //Console.WriteLine($"{admin.GetUserId()} - {admin.HasAccess()}");
            //// Manager
            //var manager = new UTManager();
            //Console.WriteLine($"{manager.GetUserId()} - {manager.HasAccess()}");

            #endregion

            #region 12.Visitor

            // Caracteristicas principales
            // 1. La funcion principal de este patron es de crear una clase Visitor
            //    que implemente una interfaz que tengo metodos con sebrecarga por cada tipo
            //    de clase y realizar los procesos que se requieran para determinado caso

            //// Visitor
            //var visitor = new ShapeExpressionVisitor();
            //// Formas
            //var circle = new Shapes.Circle(1);
            //var square = new Shapes.Square(2);
            //// Calcular su area
            //circle.Accept(visitor);
            //square.Accept(visitor);

            #endregion

            #endregion

            // Esperar accion del usuario
            Console.ReadKey();
        }
    }
}