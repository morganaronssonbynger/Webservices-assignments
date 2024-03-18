package pa6;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;

import org.tempuri.WebServicePA6Soap;
import org.tempuri.WebServicePA6SoapProxy;

import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;
import java.awt.event.ActionEvent;
import javax.swing.JTable;
import javax.swing.JScrollPane;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JTextArea;
import java.awt.SystemColor;
import java.awt.Color;
import java.awt.Font;

public class PA6Frame extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private JScrollPane scrollPane;
	private JComboBox comboBoxOptions;
	private JTextArea textAreaErrorDialog;


	public JTextArea getTextAreaErrorDialog() {
		return textAreaErrorDialog;
	}

	public void setTextAreaErrorDialog(JTextArea textAreaErrorDialog) {
		this.textAreaErrorDialog = textAreaErrorDialog;
	}

	public JComboBox getComboBoxOptions() {
		return comboBoxOptions;
	}

	public void setComboBoxOptions(JComboBox comboBoxOptions) {
		this.comboBoxOptions = comboBoxOptions;
	}

	public JTable getTable() {
		return table;
	}

	public void setTable(JTable table) {
		this.table = table;
	}

	/**
	 * Create the frame.
	 */
	public PA6Frame() {
		setTitle("CRONUS application");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 995, 661);
		contentPane = new JPanel();
		contentPane.setBackground(new Color(135, 206, 250));
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		scrollPane = new JScrollPane();
		scrollPane.setBounds(113, 126, 754, 472);
		contentPane.add(scrollPane);
		
		table = new JTable();
		scrollPane.setViewportView(table);
		
		comboBoxOptions = new JComboBox();
		comboBoxOptions.setBounds(309, 61, 339, 37);
		contentPane.add(comboBoxOptions);
		
		textAreaErrorDialog = new JTextArea();
		textAreaErrorDialog.setEditable(false);
		textAreaErrorDialog.setBackground(new Color(135, 206, 250));
		textAreaErrorDialog.setForeground(SystemColor.desktop);
		textAreaErrorDialog.setBounds(723, 11, 246, 104);
		contentPane.add(textAreaErrorDialog);
		
		JLabel lblNewLabel = new JLabel("Options:");
		lblNewLabel.setFont(new Font("Tahoma", Font.PLAIN, 15));
		lblNewLabel.setBounds(224, 64, 84, 27);
		contentPane.add(lblNewLabel);
		
	}
}
