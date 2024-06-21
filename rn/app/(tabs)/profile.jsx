import React, { useState, useEffect } from 'react';
import { SafeAreaView } from "react-native-safe-area-context";
import { Platform, Image, Modal, Text, TouchableOpacity, View } from "react-native";
import logo from "../../assets/images/Logo.png"
import { FontAwesomeIcon } from '@fortawesome/react-native-fontawesome';
import {
  faAngleRight,
  faArrowRightFromBracket,
  faPencil,
  faXmark,
  faCamera
} from '@fortawesome/free-solid-svg-icons';
import Input from '../../components/Input';
import MDateTimePicker from '../../components/DateTimePicker';
import * as ImagePicker from 'expo-image-picker';
export default function Profile() {
  const [open, setOpen] = useState(false)
  const setClose = () => {
    setOpen(false)
    setName('')
    setErrorName('')
    setEmail('')
    setErrorEmail('')
    setPhone('')
    setErrorPhone('')
    setChosenDate(new Date())

  }
  //Name
  const [name, setName] = useState('')
  const [errorName, setErrorName] = useState('')

  const onChangeName = (value) => {
    setName(value)
    setErrorName('')
  }

  //Phone
  const [phone, setPhone] = useState('')
  const [errorPhone, setErrorPhone] = useState('')

  const onChangePhone = (value) => {
    setPhone(value)
    setErrorPhone('')
  }

  //Email
  const [email, setEmail] = useState('')
  const [errorEmail, setErrorEmail] = useState('')

  const onChangeEmail = (value) => {
    setEmail(value)
    setErrorEmail('')
  }

  //Date
  const [chosenDate, setChosenDate] = useState(new Date())


  //Image
  const imagePicker = async () => {
    const result = await ImagePicker.launchImageLibraryAsync({
      mediaTypes: ImagePicker.MediaTypeOptions.Images,
      allowsEditing: true,
      aspect: [4, 3],
      quality: 1,
    });

    if (!result.cancelled) {
      console.log(result);
    }
  }

  useEffect(() => {
    (async () => {
      if (Platform.OS !== 'web') {
        const { status } = await ImagePicker.requestMediaLibraryPermissionsAsync();
        if (status !== 'granted') {
          alert('Sorry, we need camera roll permissions to make this work!');
        }
      }
    })();
  }, []);
  return (
    <SafeAreaView className='flex-1'>
      <View className="text-wrap flex items-center flex-row gap-5 px-10">
        <View className='flex flex-row items-end'>
          <Image
            source={logo}
            className="bg-white rounded-full w-[100px] h-[100px] me-4 "
          />
          <TouchableOpacity onPress={() => imagePicker()}>
            <FontAwesomeIcon icon={faCamera} />
          </TouchableOpacity>
        </View>

        <View className='me-3'>
          <Text className='font-semibold mb-2'>Ngô Trung Quân</Text>
          <Text>sinh viên</Text>
        </View>
        <TouchableOpacity onPress={() => setOpen(true)}>
          <FontAwesomeIcon icon={faPencil} />
        </TouchableOpacity>
      </View>

      <View className='px-10 my-7'>
        <TouchableOpacity className='rounded-lg w-[100%] bg-[#3A57E8] py-5 px-3 mb-3 flex justify-between flex-row items-center'>
          <Text className='text-white'>Quản lý sự kiện tham gia</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-lg w-[100%] bg-[#3A57E8] py-5 px-3 mb-3 flex justify-between flex-row items-center'>
          <Text className='text-white'>Điểm rèn luyện</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-lg w-[100%] bg-[#3A57E8] py-5 px-3 mb-3 flex justify-between flex-row items-center'>
          <Text className='text-white'>Quản lý sự kiện</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-lg w-[100%] bg-[#3A57E8] py-5 px-3 mb-3 flex justify-between flex-row items-center'>
          <Text className='text-white'>Báo cáo thống kê</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-lg w-[100%] bg-[#3A57E8] py-5 px-3 mb-3 flex justify-between flex-row items-center'>
          <Text className='text-white'>Đăng xuất</Text>
          <FontAwesomeIcon icon={faArrowRightFromBracket} color='white' />
        </TouchableOpacity>

        <Modal
          visible={open}
          animationType="slide"
          transparent={true}
          onRequestClose={() => {
            setClose();
          }}
        >
          <SafeAreaView>
            <View className='bg-white mt-16 h-full p-3'>
              <View className='flex flex-row justify-between h-[5%]'>
                <Text>Cập nhật thông tin cá nhân</Text>
                <TouchableOpacity onPress={() => setClose()} >
                  <FontAwesomeIcon icon={faXmark} className='w-[20%]' />
                </TouchableOpacity>

              </View>

              <Input value={name} handleChange={onChangeName} placeholder={'Nhập tên'} error={errorName} title={'Tên'} require />
              <Input value={phone} handleChange={onChangePhone} placeholder={'Nhập lớp'} error={errorPhone} title={'Số điện thoại'} require />
              <Input value={email} handleChange={onChangeEmail} placeholder={'Nhập email'} error={errorEmail} title={'Email'} require />
              <MDateTimePicker dateTime={chosenDate} setDateTime={setChosenDate} />

              <View className='flex justify-center items-center my-2'>
                <TouchableOpacity className='rounded-2xl w-[60%] bg-[#3A57E8] py-3 px-3 my-3 flex justify-center items-center'>
                  <Text className='text-white'>Cập nhật thông tin của bạn</Text>
                </TouchableOpacity>
              </View>

            </View>
          </SafeAreaView>

        </Modal>
      </View>

    </SafeAreaView>
  );
}
