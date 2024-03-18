package pa3;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.Color;
import java.awt.SystemColor;
import javax.swing.JTextArea;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class PA3Frame extends JFrame {

	private JPanel contentPane;
	private JTextField textFieldFilePath;
	private JTextArea textAreaFilePath;
	private JButton btnSearch;



	public JTextField getTextFieldFilePath() {
		return textFieldFilePath;
	}



	public void setTextFieldFilePath(JTextField textFieldFilePath) {
		this.textFieldFilePath = textFieldFilePath;
	}



	public JTextArea getTextAreaFilePath() {
		return textAreaFilePath;
	}



	public void setTextAreaFilePath(JTextArea textAreaFilePath) {
		this.textAreaFilePath = textAreaFilePath;
	}



	public JButton getBtnSearch() {
		return btnSearch;
	}



	public void setBtnSearch(JButton btnSearch) {
		this.btnSearch = btnSearch;
	}



	/**
	 * Create the frame.
	 */
	public PA3Frame() {
		setTitle("File reader");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 554, 438);
		contentPane = new JPanel();
		contentPane.setBackground(new Color(135, 206, 235));
		contentPane.setForeground(Color.BLACK);
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		textFieldFilePath = new JTextField();
		textFieldFilePath.setBounds(121, 26, 263, 20);
		contentPane.add(textFieldFilePath);
		textFieldFilePath.setColumns(10);
		
		JLabel lblFilePath = new JLabel("File path:");
		lblFilePath.setBounds(41, 29, 70, 14);
		contentPane.add(lblFilePath);
		
		btnSearch = new JButton("Search");
		
		btnSearch.setBounds(405, 25, 89, 23);
		contentPane.add(btnSearch);
		
		textAreaFilePath = new JTextArea();
		textAreaFilePath.setBounds(41, 62, 454, 277);
		contentPane.add(textAreaFilePath);
	}
}
