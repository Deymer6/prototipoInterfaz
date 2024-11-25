using HiveMQtt.Client;
using HiveMQtt.Client.Events;
using HiveMQtt.Client.Options;
using HiveMQtt.MQTT5.Types;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;


namespace mq
{
    public partial class Form1 : Form
    {
        private HiveMQClient client;
        private String datos = "";
        public Form1()
        {
            InitializeComponent();

            // Establecer el valor mínimo y máximo del LinearGauge
            linearGauge2.MinimumValue = 0F;  // Establecer el valor mínimo
            linearGauge2.MaximumValue = 110F; // Establecer el valor máximo

            // Establecer un valor de progreso (para mostrar el valor actual)


            // Configurar DigitalGauge
            digitalGauge1.Value = "0.0"; // Inicializar con un valor por defecto



        }


        private bool isImageVisible = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void recibir(object? sender, OnMessageReceivedEventArgs e)
        {
            try
            {
                // Convertir el mensaje recibido a un valor numérico
                if (double.TryParse(e.PublishMessage.PayloadAsString, out double valorTemperatura))
                {
                    // Actualizar el LinearGauge y DigitalGauge con los nuevos valores
                    if (linearGauge2.Visible)
                    {
                        if (InvokeRequired)
                        {
                            Invoke(new Action(() =>
                            {
                                // Actualizar el valor en los controles
                                linearGauge2.Value = (float)valorTemperatura;
                                digitalGauge1.Value = valorTemperatura.ToString("F1");

                                // Mostrar u ocultar el PictureBox basado en la temperatura
                                if (btnAlarm != null)
                                {
                                    btnAlarm.Visible = valorTemperatura > 50;
                                }
                                else
                                {
                                    MessageBox.Show("El PictureBox no está inicializado correctamente.");
                                }
                            }));
                        }
                        else
                        {
                            // Actualizar el valor en los controles
                            linearGauge2.Value = (float)valorTemperatura;
                            digitalGauge1.Value = valorTemperatura.ToString("F1");


                        }
                    }
                }
                else
                {
                    // Si la temperatura no es válida, mostrar un mensaje de error
                    MessageBox.Show("El valor recibido no es un número válido.", "Error de datos");
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                MessageBox.Show("Error al recibir los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private string mensaje = "";



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private async void btnConectar_Click(object sender, EventArgs e)
        {
            // Configuración de cliente MQTT
            var options = new HiveMQClientOptionsBuilder()
                .WithBroker("0f17d674c1dd4833919eb0b6b5bd60f9.s1.eu.hivemq.cloud")
                .WithUserName("MonitoreoCasas")
                .WithPassword("arduino123")
                .WithPort(8883)
                .WithUseTls(true)
                .Build();

            progressBarAdv1.Value = 100;

            client = new HiveMQClient(options);

            // Establecer el manejador de mensajes antes de suscribirse
            client.OnMessageReceived += recibir;

            // Conectar al broker MQTT
            var connectResult = await client.ConnectAsync().ConfigureAwait(false);

            // Suscripción al topic "temperatura"
            var builder = new SubscribeOptionsBuilder();
            builder.WithSubscription("temperatura", QualityOfService.AtLeastOnceDelivery);
            var subscribeOptions = builder.Build();
            var subscribeResult = await client.SubscribeAsync(subscribeOptions);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }








        private void btnLuz_Click(object sender, EventArgs e)
        {
            if (isImageVisible)
            {
                // Ocultar la imagen
                btnFocoImag.Visible = false;
                isImageVisible = false; // Actualizar el estado
            }
            else
            {
                // Mostrar la imagen

                btnFocoImag.Visible = true;
                isImageVisible = true; // Actualizar el estado
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     
        private void btnAlarma_Click_1(object sender, EventArgs e)
        {
            // Alternar la visibilidad de la imagen
            if (isImageVisible)
            {
                // Ocultar la imagen
                btnAlarmaImag.Visible = false;
                isImageVisible = false; // Actualizar el estado
            }
            else
            {
                // Mostrar la imagen

                btnAlarmaImag.Visible = true;
                isImageVisible = true; // Actualizar el estado
            }

        }
    }
}